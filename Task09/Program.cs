﻿// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа

//  78 -> 8
//  12-> 2
//  85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// Условный оператор
// int result = default;
// if(firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа = {result}");

// // Тернарный оператор 1
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");

// // Тернарный оператор 2
// Console.WriteLine($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int MaxDigit (int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");