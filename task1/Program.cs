/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25; b = 5 -> да 
a = 2; b = 10 -> нет 
a = 9; b = -3 -> да 
a = -3; b = 9 -> нет
*/

Console.Write("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sqr = numberB * numberB; // Расчёт квадрата числа {b}

if(numberA == sqr) // Если а равно квадрату, то выводим в консоль следующее...
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else  // Иначе...
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}
