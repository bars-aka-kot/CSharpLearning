// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length-1) System.Console.Write($"{arr[i]}");
        else System.Console.Write($"{arr[i]}, ");
    }
    System.Console.Write("]");
}


int[] array = new int[8];

FillArray(array);
PrintArray(array);