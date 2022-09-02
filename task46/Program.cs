/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] CreateArray(int m, int n, int minValue, int maxValue) // Функция для создания двумерного массива из псевдослучайных чисел.
{
    int[,] result = new int[m, n];  // Рабочий массив из m-строк и n-столбцов

    for (int i = 0; i < m; i++)  // Цикл для прохода по каждой строке.
        for (int j = 0; j < n; j++) // Цикл для прохода по каждому столбцу.
            result[i, j] = new Random().Next(minValue, maxValue + 1); // Генерация массива из псевдослучайных чисел.

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

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(m, n, 0, 100);  // Массив, которому присваиваем функцию CreateArray
PrintArray(myArray); // Вызов функции PrintArray с массивом myArray