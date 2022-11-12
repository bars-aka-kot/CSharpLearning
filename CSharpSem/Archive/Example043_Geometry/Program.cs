// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите коэфициенты функций y = k1 * x + b1, y = k2 * x + b2");
System.Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[] arr)
{
    System.Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) System.Console.Write($"{arr[i]}; ");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.WriteLine(")");
}

double[] Cross(int a, int b, int c, int d) // 5 2 9 4
{
    // при значениях в условии задачи
    double x = Convert.ToDouble((b - d)) / Convert.ToDouble((c - a)); // (2-4) / (9-5) = -2/4 = -0,5
    double y = a * x + b; // y = 5*(-0.5)+2 = -2.5+2 = -0.5
    double[] arr = { x, y }; // {-0.5, -0.5}
    return arr;
}
double[] array = Cross(a:k1, b:b1, c:k2, d:b2);
PrintArray(array);