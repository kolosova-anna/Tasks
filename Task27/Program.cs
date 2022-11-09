// Напишите программу, которая
// принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int SumNumbers(int number)
{
    int sumNumbers = 0;
    int n = default;
    n = number % 10;
    while (number >= 10 || number <= -10)
    {
        n = number % 10;
        number = number / 10;
        sumNumbers = sumNumbers + n;
    }
    sumNumbers = sumNumbers + number;
    return sumNumbers;
}

sum = SumNumbers(num);
Console.Write($"Сумма цифр в числе = {sum}");