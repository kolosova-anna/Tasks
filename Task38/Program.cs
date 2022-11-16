// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
double num = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(num, 1);
}
return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


double FindDifMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    difference = max - min;
    return difference;
}

double[] arr = CreateArrayRndDouble(8, 0, 100);
PrintArray(arr);
double dif = FindDifMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {dif}");