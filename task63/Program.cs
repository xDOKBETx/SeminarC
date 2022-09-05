/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

// Первый способ.
void PrintNaturalNums(int count, int N)  // Метод с функцией аругементами, которой являются count и N
{
    if (count > N) return; // Если количество меньше N, то возврат
    PrintNaturalNums(count, N - 1); // Вызов функции, в которой N уменьшаем на 1
    Console.Write(N + " ");
}

// Второй способ
string PrintNumsToString(int step, int N) // Строковая функция с аргументами step и N.
{
    if (step == N) return step.ToString(); // Если количество (step) равно N, возвращаем step со строковым значением. 
    return step + " " + PrintNumsToString(step + 1, N); // Возврат через конкатенацию step, "пробел" 
    // и значение функции, в которой step увеличиваем на 1.
}

Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNaturalNums(1, number); // Вызов функции с начальными значениями (1, введенное число)
Console.WriteLine();
Console.WriteLine(PrintNumsToString(1, number)); // Вывод в консоль работы функции с начальными значениями (1, введенное число).
