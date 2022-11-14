// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[] InputNumbers(string input)
{
  Console.Write(input);
  string a = Console.ReadLine();
  int[] output = a.Split(' ').Select(int.Parse).ToArray();
  return output;
}

int[,] Product2Matrix(int[,] matrix1, int[,] matrix2)
{                                               
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                temp += matrix1[i, k] * matrix2[k, j];
            }
            newMatrix[i, j] = temp;
        }
    }
    return newMatrix;
}

int[] matrix1RowsColumns = InputNumbers("Введите число строк и столбцов первой матрицы в формате 'строка столбец': ");
int[] matrix2RowsColumns = InputNumbers("Введите число строк и столбцов второй матрицы в формате 'строка столбец': ");

int[,] matrixFirst = CreateMatrixRndInt(matrix1RowsColumns[0], matrix1RowsColumns[1], 1, 10);
int[,] matrixSecond = CreateMatrixRndInt(matrix2RowsColumns[0], matrix2RowsColumns[1], 1, 10);

PrintMatrix(matrixFirst);
PrintMatrix(matrixSecond);

if (matrix1RowsColumns[1] == matrix2RowsColumns[0])
{
    int[,] matrixNew = Product2Matrix(matrixFirst, matrixSecond);
    PrintMatrix(matrixNew);
}
else Console.WriteLine("Невозможно вычислить произведение заданных матриц");