﻿/* Задача 22: Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++) // for -- Цикл, в котором инициализируем переменну "i".
// Присваиваем значение "1"; затем идёт условие: пока "i" меньше или равно "num", выполняем действие в фигурных скобках
// И после каждого прохождения цикла увеличиваем "i" на +1(чтобы сократить код пишется i++ ). 
{
    Console.Write(Math.Pow(i, 2) + ", "); // Расчёт и вывод в консоль результата возведения в квадрат "i"
}