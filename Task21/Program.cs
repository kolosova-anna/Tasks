// Напишите программу, которая \
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координаты точки A (x1, y1, z1): ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координаты точки B (x2, y2, z2): ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance (int x11, int y11, int z11, int x21, int y21, int z21)
{
    int distanceX = x11 - x21;
    int distanceY = y11 - y21;
    int distanceZ = z11 - z21;
    double distanceAB = Math.Sqrt (distanceX * distanceX
    + distanceY * distanceY + distanceZ * distanceZ);
    return distanceAB;
}

double result = Distance (x1,y1,z1,x2,y2,z2);
Console.Write ($"A ({x1}, {y1}, {z1}; B ({x2}, {y2}, {z2}" +
$" -> {Math.Round(result, 2, MidpointRounding.ToZero)}");