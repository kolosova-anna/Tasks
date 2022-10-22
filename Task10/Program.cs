// Напишите программу, которая
// 1. принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


int SecondDigit (int number)
{
    int digit = 0;
    digit = number / 10 % 10;
    return digit;
}

int secondDigit = SecondDigit (num);
string result = num > 100 && num < 1000 
       ? $"Вторая цифра числа -> {secondDigit}"
       : $"Некорректное значение";
Console.WriteLine (result);