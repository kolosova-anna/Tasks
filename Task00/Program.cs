﻿// Написать программу, которая
// 1. на вход принимает число и
// 2. выдвет его квадрат (число, умноженное на само себя).

// Например:
// 4 -> 16;
// -3 -> 9;
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// srring str = Console.ReadLine();
// int num = Convert.ToInt32(str);

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");