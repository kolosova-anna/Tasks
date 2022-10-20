// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();

string Quarter(string quarterXY)
{
    if (quarterXY == "1") return "X > 0 и Y > 0";
    if (quarterXY == "2") return "X < 0 и Y > 0";
    if (quarterXY == "3") return "X < 0 и Y < 0";
    if (quarterXY == "4") return "X > 0 и Y < 0";
    return "Некорректный ввод";
}

string xy = Quarter(quarter);
Console.Write ($"Диапазон координат для четверти {quarter}: ");
Console.WriteLine(xy);
