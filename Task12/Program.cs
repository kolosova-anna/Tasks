// Напишите программу, которая будет
// 1. принимать на вход два числа и
// 2. выводить, является ли первое число кратным второму.
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = number1 % number2;

if (remainder != 0)
{
    Console.WriteLine ($"не кратно, остаток {remainder}");
}
else Console.WriteLine ("кратно");

