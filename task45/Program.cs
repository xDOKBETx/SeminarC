/* Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];  // Массив для работы

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // Массив res, начиная с нулевого индекса "i",
        // заполняется псевдослучайными числами от minValue до maxValue + 1. +1, чтобы включить последний элемент массива,
        //  т.к. в массиве берется полуинтервал, т.е. последний элемент не входит в диапазон  
    }
    return res;
}

int[] GetCopy(int[] array)  // Функция для создания копии массива
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int[] myArray = GetArray(5, 1, 10); // Создаем массив и передаём ему значения функции GetArray с входными данными: 5 элементов от 1 до 10.
Console.WriteLine(String.Join(" ", GetCopy(myArray)));  // Вывод значений функции Getcopy в консоль. 