// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductNumArray(int[] arr)
{
    int length = arr.Length / 2;
    if (arr.Length % 2 != 0) length = length + 1;

    int[] arrNew = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - (i + 1)];
        // if (arr.Length % 2 != 0 && i == length - 1) arrNew[i] = arr[i];
        // else arrNew[i] = arr[i] * arr[arr.Length - (i + 1)];
    }
    if (arr.Length %2 !=0) arrNew[length-1] = arr[length-1];
    return arrNew;
}

System.Console.Write("Введите размер массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(lengthArray, -10, 10);
PrintArray(array);
int[] arrayNew = ProductNumArray(array);
PrintArray(arrayNew);