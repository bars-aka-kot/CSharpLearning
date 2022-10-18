// Задача 34: 
// 1. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    var arr = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]}, ");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.WriteLine("]");
}

int CountEventNum(int[] arr)
{
    int countArr = default;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] % 2 != 1) countArr++;
    }
    return countArr;
}

System.Console.Write("Введите число элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArrayRndInt(arrayLength, 100, 999);
PrintArray(array);
int countArray = CountEventNum(array);
System.Console.WriteLine($"Количество четных чисел в массиве = {countArray}");