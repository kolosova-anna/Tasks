﻿// Напишите программу, которая
// выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = default; 

while (num > 999)
{
    num = num / 10;
}
if (num > 99)
{
    digit = num % 10;
    Console.WriteLine ($"Третья цифра числа -> {digit}");
}
else Console.WriteLine ("Третьей цифры нет");

