/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArray(int size, int min, int max)  // Функция для создания массива из псевдосдучайных чисел.
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int Check(int[] mas) // Функция для поиска элементов массива лежащих в промежутке от 10 до 99.
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if ((10 <= mas[i]) && (mas[i] < 100)) // Условие: Если элемент массива больше 10(включительно) И меньше 100(не включительно)
        {
            count++; // то увеличиваем переменную-счётчик на +1
        }
    }
    return count; // Возврат значения переменной-счётчика
}

int[] array = GetArray(123, 10, 200); // Присваивание массиву значений функции GetArray
Console.WriteLine(String.Join(" ", array)); // Вывод в консоль значений массива
Console.WriteLine($"{Check(array)}");  // Вывод в консоль значения функции Check