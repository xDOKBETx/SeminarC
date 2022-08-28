/* Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) // Проверка условий х и у
{
    Console.WriteLine("1 четверть");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
