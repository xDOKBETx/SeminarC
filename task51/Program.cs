/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int row, int column, int minValue, int maxValue)  // Функция создающая двумерный массив из псевдослучайных чисел.
{
    int[,] result = new int[row, column];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }

    }
    return result;
}

void PrintArray(int[,] array)  // Метод с функцией печати массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int SumDiagonalArray(int[,] array)  // Функция для посчёта суммы элементов массива по диагонали
{
    int diagSum = 0; // Переменная куда складывается подсчёт суммы.

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) // Условие: Если элемент в строке равен элементу в столбце, то ...
            {
                diagSum += array[i, j]; // Посчитывается сумма текущего элемента и предыдущего + прибавляется сумма, которая получается в цикле
            }
        }
    }
    return diagSum; // Возврат в цикл diagSum
}

int[,] myArray = CreateArray(row, column, 1, 10);  // Присваивание новому массиву функция CreateArray
PrintArray(myArray); // Вызов функции печатающей массив в консоль
Console.WriteLine();
int resultSum = SumDiagonalArray(myArray); // Присваивание переменной результат работы функции SumDiagonalArray.
Console.WriteLine($"Сумма элементов по диагонали равна: {resultSum}"); // Вывод в консоль получившейся суммы
