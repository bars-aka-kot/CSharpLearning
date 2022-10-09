// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.
// Для 3
// 1 - 1
// 2 - 4
// 3 - 9
// Первый способ - простой метод с возвратом, второй - void метод

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// while (count <= number)
// {
//     Console.WriteLine(Square(count));
//     count++;
// }

// string Square(int num)
// {
//     return $"{num}  |  {Math.Pow(num, 2)}";
// }

void ConsolePrint(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"|\t{count}\t|\t{Math.Pow(count, 2)}\t|"); // можно так {count, 4}
        count++;
    }
}

ConsolePrint(number);