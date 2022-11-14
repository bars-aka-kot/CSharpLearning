// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int SumMatrixDiagonal(int[,] matrix)
{
    int result = default;
    int length = default;
    if (matrix.GetLength(0)>matrix.GetLength(1)) length = 1;
    
    for (int i = 0; i < matrix.GetLength(length); i++)
    {
        int j=i;
        result = result + matrix[i,j];
    }
    return result;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int rows = InputNumbers("Введите количество строк: ");
int columns = InputNumbers("Введите количество столбцов: ");

int[,] array = CreateMatrixRndInt(rows, columns, -10, 10);
int sum = SumMatrixDiagonal(array);
PrintMatrix(array);
Console.WriteLine($"Сумма для элементов массива на главной диагонали {sum}!");