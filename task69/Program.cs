/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Int64 PowRec(int a, int n)
{
    // return n == 0 ? 1 : a * PowRec(a, n - 1);  // Сокращенный вариант
    if (n == 0) return 1; // Если n равно 0, то возвращаем 1
    else if (n % 2 == 0) return PowRec(a, n - 1); // Иначе, если число чётное(делится на 2 без остатка), возвращаем число, а от степени вычитаем 1
    else return a * PowRec(a, n - 1); // Иначе возвращаем число умноженное на число и с каждым разом уменьшаем степень на 1
}

Console.Write("Введите основание степени, A(не равное 0): ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени, B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == 0 || B < 0)  // Если А равно 0 или В < 0, то вывод в консоль ... 
{
    Console.WriteLine("Введенные значения не соответсвуют условию!");
}
else // Иначе вывод в консоль результата функции PowRec
    Console.WriteLine(PowRec(A, B));


/* код итеративного решения:
int PowNumber(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}
*/
