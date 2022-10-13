// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

double Factorial(double num)
{
    double fact = 1;
    int i;
    for (i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                fact = fact * i;
            }
        }
        catch (Exception)
        {
            System.Console.WriteLine("Переполнение типа!");
            break;
        }
    }

    System.Console.WriteLine($"Факториал числа {i - 1} = {fact}");
    return fact;
}

double result = Factorial(number);
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");