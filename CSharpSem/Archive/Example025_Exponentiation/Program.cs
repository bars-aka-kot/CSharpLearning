// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите числа для решения задачи.");
System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

double Exponent(int num1, int num2)
{
    double res = 1;
    if (num2 > 0)
    {
        for (int i = 1; i <= num2; i++)
        {
            res = res * num1;
        }
    }
    if (num2 == 0) return res = 1;
    if (num2 < 0)
    {
        for (int i = 0; i > num2; i--)
        {
            res = res / num1;
        }
    }
    return res;
}

double result = Exponent(a, b);
System.Console.WriteLine($"{a} в степени {b} = {result}");