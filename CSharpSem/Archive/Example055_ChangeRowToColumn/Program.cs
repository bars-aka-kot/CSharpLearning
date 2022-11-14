// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void Compare(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        ChangeRowToColumn(matrix);
        PrintMatrix(matrix);
    }
    else Console.WriteLine("Невозможно заменить строки на столбцы");
}

int[,] ChangeRowToColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
    return matrix;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int rows = InputNumbers("Введите количество строк: ");
int columns = InputNumbers("Введите количество столбцов: ");

int[,] matrix = CreateMatrixRndInt(rows, columns, -10, 10);

PrintMatrix(matrix);
Console.WriteLine();

Compare(matrix);