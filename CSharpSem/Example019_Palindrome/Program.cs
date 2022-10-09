// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool FlipNumber(int num1)
{
    int digit1 = num1 / 10000; // 14212 / 10000 = 1
    int digit2 = num1 % 10000 / 1000; // 14212 -> 4
    int digit3 = num1 % 1000 / 100; // 14212 -> 2
    int digit4 = num1 % 100 / 10; // 14212 -> 1
    int digit5 = num1 % 10; // 14212 % 10 = 2
    int num2 = digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
    return num2 == num1;
}

if (FlipNumber(number)) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");