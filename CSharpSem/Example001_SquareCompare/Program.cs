// Задача 1. Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2) Console.WriteLine($"{number1} является квадратом числа {number2}");
else Console.WriteLine($"{number1} не является квадратом числа {number2}");