// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

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

int[] SearchIndexMinNumber(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0, minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= min)
            {
                min = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { minRow, minColumn };
}

int[,] MatrixNew(int[,] matrix)
{
    int minRow = SearchIndexMinNumber(matrix)[0];
    int minColumn = SearchIndexMinNumber(matrix)[1];
    int k = 0;
    int[,]  newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        int l = 0;
        if (k != minRow)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (l != minColumn)
                {
                    newMatrix[i, j] = matrix[k, l];
                }
                else j=j-1;
                l++;
            }
        }
        else i=i-1;
        k++;
    }
    return newMatrix;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int rows = InputNumbers("Введите количество строк: ");
int columns = InputNumbers("Введите количество столбцов: ");

int[,] array2D = CreateMatrixRndInt(rows, columns, -10, 10);
Console.WriteLine();

Console.WriteLine("Исходный массив");
PrintMatrix(array2D);

int [] arr = SearchIndexMinNumber(array2D);
PrintArray(arr);

Console.WriteLine("Обработанный массив");
int[,] array2DNew = MatrixNew(array2D);
PrintMatrix(array2DNew);