﻿/* Задача 11: Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100,1000);
int num1 = number % 10; // Получаем последнюю цифру трёхзначного числа.
int num2 = number / 100; // Получаем первую цифру трёхзначного числа.
int result = num2 * 10 + num1; // Объединяем полученные цифры. num2 умножаем на 10, чтобы получить из первого числа десятки и затем суммируем с num1
Console.WriteLine($"Получили число {result} из числа {number}");
