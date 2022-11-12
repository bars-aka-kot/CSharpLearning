// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    Console.WriteLine();
}

int RowMinSum(int[,] matrix)
{
    int rowMinSum = 0, minSum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumTemp += matrix[i, j];
        }
        if (i == 0 || sumTemp < minSum)
        {
            minSum = sumTemp;
            rowMinSum = i;
        }
    }
    return rowMinSum;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns, 1, 10);
Console.WriteLine();

Console.WriteLine("Исходный массив");
PrintMatrix(array2D);

Console.WriteLine(RowMinSum(array2D));