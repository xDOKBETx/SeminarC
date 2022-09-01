/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int num1, int num2, int num3) // Булева функция -- логический оператор сравнения
{
    return num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2; // Возврат значения истина(true), 
    // если выполняются все данные логические условия 
}

if (CheckTriangle(a, b, c))  // Условие(если), которое принимает на вход результаты выполнения функции CheckTriangle
{
    Console.Write("Да");  // Если условие выполнилось, то вывод в консоль "Да".
}
else
{
    Console.Write("Нет"); // Иначе вывод в консоль "Нет".
}
