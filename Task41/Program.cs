// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] CreateArray (int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += 1;
    }
    return sum;
}

Console.WriteLine("Введите количество элементов: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(number);
PrintArray(arr);

int sumOfElements = SumOfElements(arr);
Console.WriteLine($"Количество чисел больше 0 = {sumOfElements}");