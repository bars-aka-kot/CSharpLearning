// Задача 3. Напишите программу, которая будет 
// 1. выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Сейчас понедельник");
        break;
    case 2:
        Console.WriteLine("Сейчас вторник");
        break;
    case 3:
        Console.WriteLine("Сейчас среда");
        break;
    case 4:
        Console.WriteLine("Сейчас четверг");
        break;
    case 5:
        Console.WriteLine("Сейчас пятница");
        break;
    case 6:
        Console.WriteLine("Сейчас суббота");
        break;
    case 7:
        Console.WriteLine("Сейчас воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}