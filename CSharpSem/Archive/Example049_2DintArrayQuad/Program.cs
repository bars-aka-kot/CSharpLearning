// // Задача 49: 
// 1. Задайте двумерный массив. 
// 2. Найдите элементы, у которых оба индекса чётные, и 
// 3. замените эти элементы на их квадраты.

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

int[,] CreateMatrixQuad(int[,] matrix)
{
    int[,] matrixNew = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrixNew[i, j] = matrix[i, j] * matrix[i, j];
            else matrixNew[i, j] = matrix[i, j];
        }
    }

    return matrixNew;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] array2DNew = CreateMatrixQuad(array2D);
PrintMatrix(array2DNew);