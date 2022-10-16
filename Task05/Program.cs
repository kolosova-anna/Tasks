﻿// Напишите программу, которая 
// 1. на вход принимает одно число (N), а 
// 2. на выход показывает все целые числа в промежутке от -N до N
// 2 -> -2, -1, 0, 1, 2

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else Console.WriteLine("Введите целое положительное число"); 