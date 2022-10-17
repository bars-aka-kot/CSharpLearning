// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. Заполнить случайными числами из промежутка [-9, 9]. 
// 3. Найти сумму отрицательных и положительных элементов массива.
// 4. Вывести результат

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

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int[] GetPositiveNegativeElem(int[] array)
{
    int sumNegative = default;
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }

    // int [] result = new int [2]; 
    // result[0] = sumNegative;
    // result[1] = sumPositive;
    // return result;

    // int [] result = {sumNegative, sumPositive};
    // return result;

    return new int [] {sumNegative, sumPositive};  
}

int[] result = GetPositiveNegativeElem(arr);
System.Console.WriteLine($"Сумма положительных чисел = {result[1]}");
System.Console.WriteLine($"Сумма положительных чисел = {result[0]}");