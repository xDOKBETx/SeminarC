/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] Getarray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Convert(int[] mas) // Функция, которая в качестве аргумента принимает массив
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1; // Проходим по каждому элементу массива изменяя его значение
        // Если был положительным, то при умножении на -1, он становится отрицательным. И наоборот.

    }
    return mas;
}
int[] array = Getarray(4, -10, 11);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", Convert(array))); // В скобках вызываем функцию Convert
