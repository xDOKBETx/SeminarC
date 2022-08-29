/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int MultiNumbers(int N)
{
    int multi = 1;
    for (int i = 2; i <= N; i++) // i = 2, чтобы уменьшить количество итераций цикла, потому что 1 * 1 = 1
    {
        multi *= i; // multi = multi * i
    }
    return multi;
}

Console.WriteLine(MultiNumbers(num));
