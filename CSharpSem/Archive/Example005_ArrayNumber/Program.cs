// Задача 5. Напишите программу, которая 
// 1. на вход принимает одно число (N), 
// 2. а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"все целые числа в промежутке от -{number} до {number}: ");
int i = -number;

while (i <= number)
{
    Console.Write($"{i} ");
    i++;
}