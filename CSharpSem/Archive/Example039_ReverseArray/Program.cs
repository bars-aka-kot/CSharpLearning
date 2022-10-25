// Задача 39: Напишите программу, которая 
// 1. Задает массив
// 2. Переворачивает массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void ReverseArray(int[] arr)
{
    for (int i=0; i<arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length-(i+1)];
        arr[arr.Length-(i+1)] = temp;
    }
}

System.Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(number, -9, 9);
PrintArray(array);
ReverseArray(array); // стандартный метод Array.Reverse(array);
PrintArray(array);