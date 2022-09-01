/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void FibonacciNum(int n) // Метод принимающий в качестве аргумента число n 
{
    int[] fibArray = new int[n];
    fibArray[0] = 0;
    fibArray[1] = 1;

    for (int i = 2; i < n; i++) // i = 2, потому что по условию задачи первые два значения уже даны
    {
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2]; // Формула подсчёта числа Фибоначчи
    }

    Console.WriteLine($"Первые {n} чисел Фибоначчи: {String.Join(" ", fibArray)}");
}

FibonacciNum(n); 
