// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N),
// 2. на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (number > 0)
{
    while (i <= number / 2)
    {
        Console.Write($"{2 * i} ");
        i++;
    }
}
else Console.WriteLine("Введенное число отрицательное");