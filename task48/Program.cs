/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] CreateArray(int m, int n, int minValue, int maxValue) // Функция для создания двумерного массива из псевдослучайных чисел.
{
    int[,] result = new int[m, n];  // Рабочий массив из m-строк и n-столбцов

    for (int i = 0; i < result.GetLength(0); i++)  // Цикл для прохода по каждой строке.
        for (int j = 0; j < result.GetLength(1); j++) // Цикл для прохода по каждому столбцу.
            result[i, j] = i + j; // Присваиваем значение суммы элементов i и j каждому следующему элементу массива
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