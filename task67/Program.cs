/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumNumber(int num)
{
    return num <= 0 ? 0 : num % 10 + SumNumber(num / 10); // Если сумма меньше-равно 0, то возвращаем 0. 
    // Иначе путем деления с остатком получаем последнюю цифру и прибавляем её к значению функции Sumnumber, в которой постепенно проходим по разрядам числа(единицы, десятки, сотни и т.д.)
    // if(num <= 0) return 0;
    // else return num % 10 + SumNumber(num / 10);
}

Console.Write("Число = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumNumber(number));


/* код программы итеративный способ:
int SumNumber(int num)
{
    int SumNumber = 0;
    while (num > 0)
    {
        SumNumber = SumNumber + num % 10;
        num /= 10;
    }
    return SumNumber;
}*/
