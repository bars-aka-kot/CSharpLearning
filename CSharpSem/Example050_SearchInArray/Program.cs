// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

void SearchInArray(int[,] matrix, int row, int column)
{
    if (row < 0 && column < 0) Console.WriteLine("Введены отрицательные значения");
    else if (row < matrix.GetLength(0) && column < matrix.GetLength(0))
        Console.WriteLine($"Элемент ({row}, {column}) -> {matrix[row, column]}");
    else Console.WriteLine($"({row}, {column}) -> такого элемента в массиве нет");
}

int[,] array = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(array);
Console.Write("Введите координаты элемента в формате (строка столбец): ");
string str = Console.ReadLine();
int[] strArray = str.Split(" ").Select(int.Parse).ToArray();

SearchInArray(array, strArray[0], strArray[1]);