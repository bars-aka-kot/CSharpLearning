// Задача 14. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// проверка на кратность любым двум числам

Console.WriteLine("Программа для проверки кратности одного числа любым двум другим");
Console.Write("Введите число для проверки: ");
int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число для кратности: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число для кратности: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Первый способ, без объявления метода. Требует ввод одного числа.
// Проверяет на кратность двум числам 7, 23.

// int div7 = a % 7;
// int div23 = a % 23;
// if (div7 == 0 && div23 == 0) Console.WriteLine($"Число {a} кратно 7 и 23");
// else Console.WriteLine($"Число {a} не кратно 7 и 23");

// Второй способ. Метод, проверяет на кратность двум любым числам.
// Требует ввода 3-х чисел

// bool Diff(int num, int num1, int num2)
// // проверяет, является ли num кратным и num 1 и num 2 одновременно
// {
//     return num % num1 == 0 && num % num2 == 0;
// }

// if (Diff(a, b, c)) Console.WriteLine($"Число {a} кратно {b} и {c}");
// else Console.WriteLine($"Число {a} не кратно {b} и {c}");

// Третий способ. Метод универсальный. Требует ввод одного числа.
// Проверяет на кратность двум числам 7 и 23

bool Remains(int num1, int num2)
{
    return num1 % num2 == 0;
}
if (Remains(a, 7) && Remains(a, 23)) Console.WriteLine($"Число {a} кратно 7 и 23");
else Console.WriteLine($"Число {a} не кратно 7 и 23");