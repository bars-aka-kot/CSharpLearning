// Задача 12. Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли второе число кратным первому. 
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.WriteLine("Введите два числа для сравнения");
System.Console.WriteLine("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// int div = firstNumber % secondNumber;

// if (div != 0) Console.WriteLine($"{firstNumber}, {secondNumber} => Не кратно, остаток {div}");
// else Console.WriteLine($"{firstNumber}, {secondNumber} => Кратно");

bool Kratn (int num1, int num2)
{
    int a = num1 % num2;
    return a != 0 ? true : false;
}

int div = firstNumber % secondNumber;

bool res = Kratn (firstNumber, secondNumber);
if (res == true) Console.WriteLine($"{firstNumber}, {secondNumber} => Не кратно, остаток {div}");
else Console.WriteLine($"{firstNumber}, {secondNumber} => Кратно");