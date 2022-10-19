// 11. Напишите программу, котора
// 1.  выводит случайное трёхзначное число и
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число => {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int num = firstDigit * 10 + thirdDigit;

// Console.WriteLine($"Новое число => {num}");



int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int Num (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}
int res = Num (number);
Console.WriteLine($"Новое число => {num}");