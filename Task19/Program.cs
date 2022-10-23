// Напишите программу, которая
// 1. принимает на вход пятизначное число и
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckNumber (int num)
{
    if (num / 10000 == num % 10
    && num / 1000 % 10 == num / 10 % 10) return true;
    return false;
}

if (number > 9999 && number < 100000)
{
    bool result = CheckNumber (number);
    if (result)
    {
        Console.WriteLine ("Да");
    } 
    else Console.WriteLine("нет");
}
else Console.WriteLine("Недопустимое значение");
