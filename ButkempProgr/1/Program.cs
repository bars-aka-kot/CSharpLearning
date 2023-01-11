using System.Diagnostics;

// Вычислить максимальную сумму 3-х элементов массива, стоящих подряд
// array (произвольный, количество произвольно)
// m = 3

int size = 1000000;

int m = 50000;

int[] array = Enumerable.Range(1, size).Select(item => Random.Shared.Next(10)).ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;
for (int i = 0; i < array.Length - m; i++)
{
    int t = 0;
    for (int j = i; j < i + m; j++)
    {
        t += array[j];
    }
    if (t > max)
        max = t;
}
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine($"Способ 1 = {max}");

Stopwatch sw1 = new();
sw1.Start();

int max1 = 0;
for (int j = 0; j < m; j++)
    max1 += array[j];
int t1 = max1;
for (int i = 1; i < array.Length - m; i++)
{
    t1 = t1 - array[i - 1] + array[i + (m - 1)];
    if (t1 > max1)
        max1 = t1;
}

sw1.Stop();
Console.WriteLine($"time = {sw1.ElapsedMilliseconds}");
Console.WriteLine(($"Способ 2 = {max1}"));
