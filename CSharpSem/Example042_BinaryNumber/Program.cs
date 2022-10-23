// Задача 42. Напишите программу, которая
// будет преобразовывать десятичное число в двоичнное.

System.Console.Write("Введите число: ");
// string a = Console.ReadLine();
int number = Convert.ToInt32(Console.ReadLine());
// int size = a.Length;

// 45 = 101101
int ConvertBinaryNumber(int num)
{
    int result = default;
    int count = 1;
    while (num > 0)
    {
        int div = num % 2;
        num = num / 2;
        result = result + div * count;
        count = 10 * count;
    }
    return result;
}

int res = ConvertBinaryNumber(number);
System.Console.WriteLine($"{number} в двоичном формате -> {res}");

// Метод решения через строку

string DecToBin(int num1)
{
    string result = String.Empty;
    while (num1> 0)
    {
        result = Convert.ToString(num1 % 2) + result;
        num1 = num1 / 2;
    }
    return result;
}

string decToBin = DecToBin(number);
System.Console.WriteLine($"{number} в двоичном формате -> {decToBin}");