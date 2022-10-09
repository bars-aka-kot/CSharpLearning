// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// дополнительно - проверка если равно 0 или больше 7
// 6 -> да
// 7 -> да
// 1 -> нет

// Первый способ - без обявления метода

// Console.Write("Введите день недели: ");
// int dayOfWeek = Convert.ToInt32(Console.ReadLine());
// if (dayOfWeek == 6 || dayOfWeek == 7) Console.WriteLine($"{dayOfWeek} -> да");
// else if (dayOfWeek > 0 && dayOfWeek <6) Console.WriteLine($"{dayOfWeek} -> нет");
// else Console.WriteLine("Нет такого дня недели");

// Второй способ. Объявление метода

// string DayOfWeek(int num)
// {
//     string res = default;
//     if (num == 6 || num == 7) res = $"{num} -> да";
//     else if (num > 0 && num <6) res = $"{num} -> нет";
//     else res = "нет такого дня недели";
//     return res;
// }

// Console.Write("Введите день недели: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string result = DayOfWeek(a);
// Console.WriteLine(result);

// Третий способ

bool DayOfWeek(int a)
{
    if (a > 0) return a == 6 || a == 7;
    else return false;
}

Console.Write("Введите день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek(dayOfWeek)) Console.WriteLine($"{dayOfWeek} -> Да");
else if (dayOfWeek <= 0 || dayOfWeek > 7) Console.WriteLine($"{dayOfWeek} -> Некорректный номер");
else Console.WriteLine($"{dayOfWeek} -> Нет");