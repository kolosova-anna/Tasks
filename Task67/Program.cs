// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumElemNumber(int num)
{
    if (num == 0) return num;
    return num % 10 + SumElemNumber(num / 10);

} 

int sumElemNumber = SumElemNumber(number);
Console.WriteLine($"Сумма цифр числа = {sumElemNumber}");