// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите два числа на проверку");
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber*firstNumber == secondNumber) Console.Write($"{firstNumber}, {secondNumber} -> да");
// else if (secondNumber * secondNumber == firstNumber) Console.Write($"{firstNumber}, {secondNumber} -> да");
// else Console.Write($"{firstNumber}, {secondNumber} -> нет");

bool Quart(int num1, int num2)
{
    return (firstNumber*firstNumber==secondNumber || secondNumber* secondNumber == firstNumber);
}

if (Quart(firstNumber, secondNumber)) Console.Write($"{firstNumber}, {secondNumber} -> да");
else Console.Write($"{firstNumber}, {secondNumber} -> нет");