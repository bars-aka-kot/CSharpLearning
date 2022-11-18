// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
int m = InputNumbers("Введите целое число M: ");
int n = InputNumbers("Введите целое число N: ");

int SumNumbers(int num1, int num2)
{
    int sumTemp = num1;
    if (num1 == num2)
        return sumTemp;
    sumTemp = sumTemp + SumNumbers(num1 + 1, num2);
    return sumTemp;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int sumNumber = 0;
if (n > m)
    sumNumber = SumNumbers(m, n);
else
    sumNumber = SumNumbers(n, m);

Console.Write($"M = {m}; N = {n} -> {sumNumber}");
