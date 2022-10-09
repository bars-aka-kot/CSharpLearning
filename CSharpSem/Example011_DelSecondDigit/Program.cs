// Задача 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Дано число => {number}");

int Del_2(int num)
{
    int a = num / 100; // 456 / 10 = 45
    int c = num % 10; // 456 % 10 = 6
    return a * 10 + c;
}

// int result = Del_2(number);
// Console.WriteLine($"Убрали из числа {number} вторую цифру. Вот результат => {result}");
Console.WriteLine($"Из числа {number} убрали вторую цифру. Вот результат: {Del_2(number)}");