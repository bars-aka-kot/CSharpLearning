// Задача 20: Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите координаты двух точек A и В");
System.Console.Write("XА: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("YА: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("XВ: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("YВ: ");
int yB = Convert.ToInt32(Console.ReadLine());

double Quart(int a, int b, int c, int d)
{
    return Math.Pow((a - b), 2) + Math.Pow((c - d), 2);
}

double result = Math.Round(Math.Sqrt(Quart(xA, xB, yA, yB)), 2, MidpointRounding.ToZero);
System.Console.WriteLine($"A({xA}, {yA}); B({xB}, {yB}) -> {result}");