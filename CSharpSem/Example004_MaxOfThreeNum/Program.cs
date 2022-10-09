// Задача 4: Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 < number2) max = number2;
if (number3 > max) max = number3;
Console.WriteLine($"Максимальное число = {max}");