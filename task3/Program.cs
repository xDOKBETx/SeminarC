/* 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
    3 -> Среда 
    5 -> Пятница
*/

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day) // switch -- (переключатель) оператор, который захватывает выражение или переменную
{
    case 1:  // case -- (случай) хранит в себе значение введенное в консоль пользователем
        Console.WriteLine("Понедельник");
        break;  // break -- нужен, чтобы программа останавливалась после нахождения и вывода соответствия
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
        default:
        Console.WriteLine("Введенное число не соответсвует диапозону от 1 до 7");
        break;
}