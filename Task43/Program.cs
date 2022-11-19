﻿// Напишите программу, которая
// найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindIntersectionPoint (double b11, double k11, double b22, double k22)
{
    double x = (b22 - b11) / (k11 - k22);
    double y = k11 * x + b11;
    int size = 2;
    double[] array = new double[size];
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] arr = FindIntersectionPoint(b1, k1, b2, k2);
PrintArray(arr);