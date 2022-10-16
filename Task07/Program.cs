// Написать программу, которая
// 1. принимает на вход трехзначное число и
// 2. на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int lastDigit = number % 10;  // 456 % 10 = 6; 456 / 10 = 45. 45 / 10 = 4. 4 / 10 = 0
    Console.WriteLine($"Последняя цифра числа = {lastDigit}");
}
else Console.WriteLine("Введите трехзначное число!");