// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNumOddPosition(int[] arr)
{
    int sum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum = sum + arr[i];
    }
    return sum;
}

System.Console.Write("Введите количество элементов массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(lenght, -20, 20);
PrintArray(array);
int sumNum = SumNumOddPosition(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях = {sumNum}");