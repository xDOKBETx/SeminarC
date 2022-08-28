/* Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sqr1 = num1 * num1; // Расчитываем квадрат числа num1
int sqr2 = num2 * num2; // Рассчитываем квадрат числа num2
if ((sqr1 == num2) || (sqr2 == num1)) // В условии if сравниваем полученые значения квадратов с числами.
// || -- оператор логическое "ИЛИ" 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
