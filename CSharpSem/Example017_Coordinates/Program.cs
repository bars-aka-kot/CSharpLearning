// Задача 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// 2. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quart(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return default;
}

int quart = Quart(x, y);
string result = quart > 0 ? $"Указанная точка находится в {quart} четверти"
                            : "Введены некоректные координаты";
System.Console.WriteLine(result);