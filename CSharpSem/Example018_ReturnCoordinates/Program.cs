// Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
string quart = Console.ReadLine();

string Quart(string quartc)
{
    if (quartc == "1") return $"Диапазон значений для {quart} четверти - x > 0 и y > 0";
    if (quartc == "2") return $"Диапазон значений для {quart} четверти - x < 0 и y > 0";
    if (quartc == "3") return $"Диапазон значений для {quart} четверти - x < 0 и y < 0";
    if (quartc == "4") return $"Диапазон значений для {quart} четверти - x > 0 и y < 0";
    return "Введен недопустимый номер";
}

Console.WriteLine(Quart(quart));