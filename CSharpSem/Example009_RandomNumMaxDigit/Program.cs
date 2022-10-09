// Задача 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(1, 100);

Console.WriteLine($"Случайное число из диапазона (10,99) => {number}");

// int secondDigit = number % 10;
// int firstDigit = (number - secondDigit) / 10;
// if (firstDigit == secondDigit) Console.WriteLine($"Максимальной цифры из числа {number} нет. Цифра {firstDigit}");
// else
// {
//     int res = Math.Max(firstDigit, secondDigit);
//     System.Console.WriteLine($"Максимальная цифра из числа {number} => {res}");
// }

int MaxDigit(int num)
{
    int secondDigit = num % 10; // 78 & 10 = 8
    int firstDigit = num / 10; // 78 / 10 = 7
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;

    // int result = default;
    //     if (firstDigit > secondDigit) result = firstDigit;
    //     else result = secondDigit;


    // result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

int maxDigit = MaxDigit(number);
System.Console.WriteLine($"Наибольшая цифра из числа {number} => {maxDigit}");