/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter)
{
    case 1:
        {
            Console.Write("x > 0 & y > 0");
            break;
        }

    case 2:
        {
            Console.Write("x < 0 & y > 0");
            break;
        }

    case 3:
        {
            Console.Write("x < 0 & y < 0");
            break;
        }

    case 4:
        {
            Console.Write("x > 0 & y < 0");
            break;
        }

    default:
        {
            Console.Write("Введенное число не соответсвует номеру четверти");
            break;
        }
}
