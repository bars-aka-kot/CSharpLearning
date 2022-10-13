// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {   
        Random rnd = new Random();
        arr[i] = rnd.Next(0, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}


int[] array = new int[20];

FillArray(array);
PrintArray(array);