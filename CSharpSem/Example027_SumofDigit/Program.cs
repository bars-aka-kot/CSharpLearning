// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SummDigit(int num)
{
    int sum = default;
    while (num > 0)
    {
        int digit = num % 10; // остаток от деления на 10 - последняя цифра числа
        num = num / 10;
        sum = sum + digit;
    }
    return sum;
}

int result = SummDigit(number);
System.Console.WriteLine($"Сумма цифр числа {number} = {result}");