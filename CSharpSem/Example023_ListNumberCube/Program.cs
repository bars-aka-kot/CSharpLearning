// Задача 23. Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ConsolePrint(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,2} |\t{Math.Pow(count, 2)}");
        count++;
    }
}

ConsolePrint(number);