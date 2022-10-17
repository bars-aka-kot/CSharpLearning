// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. Заполнить случайными числами из промежутка [-9, 9]. 
// 3. Найти сумму отрицательных и положительных элементов массива.
// 4. Вывести результат

System.Console.Write("Введите количество элементов массива: ");
int countArray = Convert.ToInt32(Console.ReadLine());

void CreateArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) System.Console.Write($"{arr[i]}");
        else System.Console.Write($"{arr[i]}, ");
    }
    System.Console.WriteLine("]");
}

void SumNumArray(int[] arr)
{
    int positiveSum = default;
    int negativeSum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum = positiveSum + arr[i];
        }
        else negativeSum = negativeSum + arr[i];
    }
    System.Console.WriteLine($"Сумма положительных членов массива = {positiveSum}");
    System.Console.WriteLine($"Сумма отрицательных членов массива = {negativeSum}");
}

int[] array = new int[countArray];

CreateArray(array);
PrintArray(array);
SumNumArray(array);