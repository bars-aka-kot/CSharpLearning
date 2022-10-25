// Задача 24. Напишите программу, которая
// 1. принимает на вход число А и 
// 2. выдает сумму чисел от 1 до А

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}

int sumNumbers = SumNumbers(a);
System.Console.WriteLine($"Сумма чисел от 1 до {a} = {sumNumbers}");