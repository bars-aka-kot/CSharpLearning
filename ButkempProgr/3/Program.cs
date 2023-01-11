int n = 140;
int m = 175;
int nok = m*n;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
}
Console.WriteLine(n);

nok = nok/n;
Console.WriteLine(nok);
// НОК(a,b) = a*b/НОД(a,b) 
