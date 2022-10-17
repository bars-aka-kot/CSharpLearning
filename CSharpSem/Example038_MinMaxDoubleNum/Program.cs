// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    var arr = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]}, ");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.WriteLine("]");
}

double MinNum(double[] arr)
{
    double minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum) minNum = arr[i];
    }
    return minNum;
}

double MaxNum(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum) maxNum = arr[i];
    }
    return maxNum;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndInt(length, -100, 100);
PrintArray(array);
double max = MaxNum(array);
double min = MinNum(array);
double diff = Math.Round((max - min),2);
System.Console.WriteLine($"Разница между максимальным и минимальным = {diff}");