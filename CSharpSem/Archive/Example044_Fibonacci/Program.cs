// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.Write("Введите количество чисел для ряда Фибоначчи: ");
int count = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndInt(int quant)
{
    double[] arr = new double[quant];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < quant; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(double[] arr)
{
    // System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]} ");
        else System.Console.Write($"{arr[i]}");
    }
    // System.Console.WriteLine("]");
}

double[] fibonacci = CreateArrayRndInt(count);
Console.Write($"Если N = {count} -> ");
PrintArray(fibonacci);

// Второй способ решения без массива

void Fibonacci(int quant)
{
    int firstNumber = 0;
    int secondNumber = 1;
    System.Console.Write($"{firstNumber} {secondNumber} ");
    for (int i = 2; i < quant; i++)
    {
        int nextNumber = firstNumber+secondNumber;
        System.Console.Write($"{nextNumber} ");
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
}
System.Console.WriteLine();
Fibonacci(count);