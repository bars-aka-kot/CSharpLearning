// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

System.Console.Write("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArr(int quant)
{
    int[] arr = new int[quant];
    for (int i = 0; i < quant; i++)
    {
        System.Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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
    System.Console.Write("]");
}

int CountPositive(int[] arr)
{
    int quant = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) quant = quant + 1;
    }
    return quant;
}

int[] array = CreateArr(number);
System.Console.Write("Введены числа ");
PrintArray(array);
int count = CountPositive(array);
System.Console.Write($". Из них больше нуля -> {count}.");

// Попытка вывести массив положительных чисел из предыдушего массива. Не закончена.
// 
// int[] PositiveNumber(int[] arr, int quant)
// {
//     int[] arrNew = new int[quant]; //int[3]
//     for (int i = 0; i < arr.Length; i++)  // i = 6
//     {
//         for (int j = 0; j < quant; j++)   // j = 0
//         {
//             if (arr[i] > 0)               // 3
//             {
//                 arrNew[j] = arr[i];       // 3
//                 break;
//             }
//             else break;
//         }
//     }
//     return arrNew;
// }