/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
// Решение как в задаче 63
void PrintNumsBetween(int M, int N)
{
    if (M > N) return;
    PrintNumsBetween(M, N - 1);
    Console.Write(N + " ");
}

string PrintToStringNumsBetween(int startNum, int endNum)
{
    if (startNum == endNum) return startNum.ToString();
    return startNum + " " + PrintToStringNumsBetween(startNum + 1, endNum);
}

Console.Write("M = ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int numN = Convert.ToInt32(Console.ReadLine());
PrintNumsBetween(numM, numN);
Console.WriteLine();
Console.Write(PrintToStringNumsBetween(numM, numN));
