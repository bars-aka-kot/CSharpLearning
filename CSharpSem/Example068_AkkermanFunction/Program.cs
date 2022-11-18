// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    if ((a != 0) && (b == 0))
        return Akkerman(a - 1, 1);
    return Akkerman(a - 1, Akkerman(a, b - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.Clear();
int m = InputNumbers("Введите целое число m: ");
int n = InputNumbers("Введите целое число n: ");
Console.Write($"m = {m}, n = {n} -> A(m, n) = {Akkerman(m, n)}");
