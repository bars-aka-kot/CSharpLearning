// Задача 40: Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

System.Console.WriteLine("Введите три целых числа");
System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    return (num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2);
}

bool result = Triangle(number1, number2, number3);
if (result) System.Console.WriteLine($"Треугольник с сторонами {number1}, {number2}, {number3} существует");
else System.Console.WriteLine($"Треугольник с сторонами {number1}, {number2}, {number3} не существует");