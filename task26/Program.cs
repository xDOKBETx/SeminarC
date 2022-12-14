/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumOfDigits(int digits) // Функция
{
    int i = 0; // Переменная - счётчик
    while(digits != 0) // Цикл пока количество цифр не равно 0, чтобы иметь возможность пройтись циклом даже по отрицательному значению num
    {
        i++;
        digits /= 10; // Можно записать как digits = digits / 10. 
        // Данная формула позволяет "откусывать" от digits по одной цифре справа и потом счётчик подсчитывает сколько раз прошелся цикл
    }
    return i;
}

Console.WriteLine(NumOfDigits(num));