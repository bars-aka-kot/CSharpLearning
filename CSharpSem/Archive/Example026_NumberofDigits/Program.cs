// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Введите число: ");
string a = Console.ReadLine();
// int number = Convert.ToInt32(a);

int NumberOfDigits(string num)
{
    int length = num.Length;
    int i = 0;
    while (i < length)
    {
        i++;
    }
    return i;
}
int numberDigits = NumberOfDigits(a);
System.Console.WriteLine($"Количество цифр в числе {a} = {numberDigits}");