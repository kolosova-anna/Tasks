// Напишите программу, которая
// 1. принимает на вход число и
// 2. проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine ("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;

// if (number % num1 == 0 && number % num2 == 0)
// {
//     Console.WriteLine ("да");
// }
// else Console.WriteLine ("нет");

// Вариант 2
bool DivNum(int digit, int num1, int num2)
{
    int result1 = digit % num1;
    int result2 = digit % num2;
    if (result1 == 0 && result2 == 0) return true;
    return false;
}
Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

bool result = DivNum( num, number1, number2);
if (result)
{
    Console.WriteLine ("да");
}
else Console.WriteLine ("нет");
