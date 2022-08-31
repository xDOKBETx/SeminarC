/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Write("Введите число для поиска: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
string Result = "отсутствует";

int[] CreateArray(int size, int min, int max)  // Функция создания массива из псевдослучайных чисел.
{
    int[] arr = new int[size];  // Рабочий массив для создания 
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);  // Массив псевдослучайных чисел
    }
    return arr;
}

bool FindNumber(int[] array, int Number)  // Функция для поиска заданного числа.
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true; // Условие: Если элемент массива под индексом "i" равен заданному числу,
        // то возвращаем "истину"
    }
    return false;
}

void PrinArray(int[] arr)  // Функция для печати массива в консоли.
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(size, min, max); // Создаём массив и присваиваем ему результаты функции CreateArray
PrinArray(array);  // Вызов функции печати массива в консоли
if (FindNumber(array, Number)) Result = "присутствует"; // Условие: При вызове функции FindNumber, 
//если в массиве будет найдено заданное число, то вывод его в консоль 
Console.WriteLine($"Число {Number} {Result} в массиве");
Console.WriteLine();
