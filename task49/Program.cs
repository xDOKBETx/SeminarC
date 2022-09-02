/* Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] CreateArray(int row, int column) // Функция для создания двумерного массива из псевдослучайных чисел.
{
    int[,] result = new int[row, column];  // Рабочий массив из row-строк и column-столбцов

    for (int i = 0; i < row; i++)  // Цикл для прохода по каждой строке.
        for (int j = 0; j < column; j++) // Цикл для прохода по каждому столбцу.
            result[i, j] = new Random().Next(1, 10); // Генерация массива из заданного диапазона

    return result; // Возврат значений рабочего массива.
}

void PrintArray(int[,] array)  // Метод void для функции печатающей двумерный массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++) // Метод .GetLength(0) возвращает количество элементов в направлении строки в многомерном массиве.
    {
        for (int j = 0; j < array.GetLength(1); j++)  // Метод .GetLength(1) возвращает количество элементов в направлении столбца многомерного массива.
            Console.Write($"{array[i, j]} "); // Умная строка печатающая двумерный массив в консоль
        Console.WriteLine();
    }
}

int[,] CorrectArray(int[,] arr) // Функция для корректировки массива.
{
    for (int i = 0; i < arr.GetLength(0); i++) // Метод .GetLength(0) возвращает количество элементов в направлении строки в многомерном массиве.
    {
        for (int j = 0; j < arr.GetLength(1); j++)  // Метод .GetLength(1) возвращает количество элементов в направлении столбца многомерного массива.
        {
            if (i % 2 == 0 && j % 2 == 0) // Проверка на четность элементов строки и столбца
            {
                arr[i, j] *= arr[i, j]; // Формула получения квадрата числа
            }
        }
    }
    return arr; // Возвращаем массив.
}

Console.Write("row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("column = ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(row, column);  // Массив, которому присваиваем функцию CreateArray
PrintArray(myArray); // Вызов функции PrintArray с массивом myArray
Console.WriteLine();
myArray = CorrectArray(myArray);  // Присваивание значений функции CorrectArray значению myArray
PrintArray(myArray); // Вызов функции PrintArray с уже измененным массивом myArray
