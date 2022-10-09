// Задача 21
// Напишите программу, которая 
// 1.принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты двух точек A и В");
System.Console.Write("XА: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("YА: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ZА: ");
int zA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("XВ: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("YВ: ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ZB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Quart(int a, int b, int c, int d, int e, int f)
{
    return Math.Pow((a - b), 2) + Math.Pow((c - d), 2) + Math.Pow((e - f), 2);
}

double result = Math.Round(Math.Sqrt(Quart(xA, xB, yA, yB, zA, zB)), 2, MidpointRounding.ToZero);
System.Console.WriteLine($"A({xA}, {yA}, {zA}); B({xB}, {yB}, {zB}) -> {result}");