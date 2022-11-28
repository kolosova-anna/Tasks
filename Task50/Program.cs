﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

void CheckPosition(int[,] matrix, int i, int j)
{
    if(i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
    Console.WriteLine ($"На позиции [{i}, {j}] находится элемент {matrix[i,j]}");
    else Console.WriteLine ($"Такого элемента в массиве нет");
}

int[,] array2D = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2D);
Console.WriteLine($"Введите позицию элемента в формате (строка, столбец) через enter: ");
int i1 = Convert.ToInt32(Console.ReadLine());
int j1 = Convert.ToInt32(Console.ReadLine());
if(i1 >= 0 && j1 >= 0)
{
CheckPosition(array2D, i1, j1);
}
else Console.WriteLine("Введите значение большее или равное 0");