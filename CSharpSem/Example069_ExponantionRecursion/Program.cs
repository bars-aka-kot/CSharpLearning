// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
int a = InputNumbers("Введите целое число A: ");
int b = InputNumbers("Введите целое число B: ");

int ExponantionNumber(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * ExponantionNumber(num1, num2 - 1);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int res = ExponantionNumber(a, b);
Console.Write(res);