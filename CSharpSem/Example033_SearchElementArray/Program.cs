// Задача 33: 
// 1. Задайте массив. 
// 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");
}

bool Search(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element) return true;
    }
    return false;
}
int[] arr = CreateArrayRndInt(100, -40, 40);
PrintArray(arr);

// if (Search(arr, 5)) ? System.Console.WriteLine("да") | System.Console.WriteLine("нет");

System.Console.WriteLine(Search(arr, 5)? "да":"нет");