/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно, программа должна вывести сообщение для пользователя.
 */

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int row, int column, int minValue, int maxValue) // Функция для создания двумерного массива.
{
    int[,] array = new int[row, column];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arrayPrint)  // Функция печати массива в консоль
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ReplacingRowsArray(int[,] arrayRows)  // Функция для замены значений элементов в строках на элементы из столбцов
{
    int[,] temp = new int[arrayRows.GetLength(0), arrayRows.GetLength(1)]; // Новый временный массив с длиной строк и столбцов.

    for (int i = 0; i < arrayRows.GetLength(0); i++) // Циклом по строкам
    {
        for (int j = 0; j < arrayRows.GetLength(1); j++) // Циклом по столбцам
        {
            temp[i, j] = arrayRows[j, i]; // Присваиваем значения  j-элемент строки и i-элемент столбца = > i-элемент строки и j-элемент столбца [i,j] < = [j,i] 
        }
    }
    return temp; // Возврат массива в работу функции.
}

int[,] myArray = GetArray(row, column, 1, 10); // Присваиваем новому массиву myArray значения функции GetArray 
// с количеством строк = row; столбцов = column; minValue = 1; maxValue = 10 
PrintArray(myArray);  // Вызов функции печати массива.
Console.WriteLine();

if (myArray.GetLength(0) == myArray.GetLength(1)) // Если элемент строки равен элементу столбца, то ...
{
    PrintArray(ReplacingRowsArray(myArray)); // Вызов функции печати с вложенной функцией замены строк на столбцы двумерного массива
}
else // Иначе...
    Console.WriteLine("Количество строк не совпадает с количеством столбцов!");


