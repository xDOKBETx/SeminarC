/* Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/

void ChangeMatrixRows(int[,] matrix)  // Метод с функцией меняющей строки двумерного массив
{

    int temp; // Объявляем целочисленную переменную без вложенного значения.

    for (int i = 0; i < matrix.GetLength(1); i++) // Проходим циклом по столбцам
    {
        temp = matrix[0, i]; // Присваиваем переменной значение массива с нулевой строкой и столбцом со значение i.
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];  // Присваиваем массиву значение последней строки и столбца со значением i.
        matrix[matrix.GetLength(0) - 1, i] = temp; // Присваиваем массиву с последней строкой значение находящееся в переменной temp на данный момент.
    }

}

int[,] GetArray(int row, int col, int beginNum, int endNum) // Функция для создания двумерного массива.
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;  // Возврат массива.
}

Console.Write("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число диапазона: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число диапазона: ");
int endNum = Convert.ToInt32(Console.ReadLine());

int[,] MyMatrix = GetArray(row, col, beginNum, endNum);  // Создаем массив и присваиваем ему значение функции GetArray.

void PrintArray(int[,] inArray) // Метод void с функцией для печати масиива в консоль, где в качестве аргумента принимается двумерный массив InArray.
{
    for (int i = 0; i < inArray.GetLength(0); i++)  // Проход циклом по строкам.
    {
        for (int j = 0; j < inArray.GetLength(1); j++)  // Проход циклом по столбцам.
        {
            Console.Write($"{inArray[i, j]} ");  // Запись массива.
        }
        Console.WriteLine();
    }
}

PrintArray(MyMatrix);  // Вызов функции PrintArray.
ChangeMatrixRows(MyMatrix); // Вызов функции ChangeMatrixRows
Console.WriteLine();
PrintArray(MyMatrix); // Вызов функции PrintArray.

