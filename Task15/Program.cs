// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите целое число от 1 до 7");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 1 && number < 8)

//     if (number == 6 || number ==7)
//     {
//         Console.WriteLine("да");
//     }
//     else Console.WriteLine("нет");

// else Console.WriteLine("Недопустимое значение");


bool Day(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}

Console.WriteLine("Введите целое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1 && number < 8)
{
    bool result = Day(number);
    if (result)
    {
    Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else Console.WriteLine("Недопустимое значение");