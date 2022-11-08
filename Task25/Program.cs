//  Напишите цикл, который
//  принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Degree(int number1, int number2)
{
    int degree = 1;
    for (int i = 1; i <= number2; i++)
    {
        degree *= number1;
    }
    return degree;
}

if (num2 > 1)
{
    int digit = Degree(num1, num2);
    Console.WriteLine($"{num1} в степени {num2} => {digit}");
}
else Console.WriteLine("Недопустимое значение");