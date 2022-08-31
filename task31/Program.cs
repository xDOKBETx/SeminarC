/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
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

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)   // Прописываем тип "int" одного элемента "el" в массиве "array"
//  foreach(цикл) берёт один элемент и внутри цикла выполняет с ним операции
{
      // Условие ? выполнилось : не выполнилось
    positiveSum += el > 0 ? el : 0;  // Тернарный оператор проверяет выполняется ли условие el > 0 ?.
    // Если да, то  positveSum равно (el + positiveSum). Иначе к positiveSum прибавляется 0.
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"positiveSum = {positiveSum} negativeSum = {negativeSum}");
