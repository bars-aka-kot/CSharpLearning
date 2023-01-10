using System.Diagnostics;

// Вычислить максимальную сумму 3-х элементов массива, стоящих подряд
// array (произвольный, количество произвольно)
// m = 3

int size = 1000000;

int m = 30000;

int[] array = Enumerable.Range(1, size).Select(item => Random.Shared.Next(10)).ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int j = 0; j < m; j++)
    max += array[j];
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max)
        max = t;
}
sw.Stop();

Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);