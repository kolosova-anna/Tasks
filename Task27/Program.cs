// Напишите программу, которая
// принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sumNumbers = default;
    int n = default;
    n = number % 10;
    while (number > 10 || number < -11)
    {
        
        number = number / 10;
    }
    n = number;
    sumNumbers = sumNumbers + n;
    return sumNumbers;
}

int sum = SumNumbers(num);
Console.Write($"Сумма цифр в числе = {sum}");