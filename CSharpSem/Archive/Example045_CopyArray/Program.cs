// Задача 45: Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] arr)
{
    int length = arr.Length;
    var arrNew = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrNew[i] = arr[i];
    }
    return arrNew;
}

System.Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(count, 0, 9);
int [] arrayNew = CopyArray(array);
Console.Write($"Изначальный массив: ");
PrintArray(array);
Console.Write($"Копия массива: ");
PrintArray(arrayNew);