// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] b = new int[a.Length];

int c = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 00)
    {
        b[c++] = a[i];
    }
}

Console.Write("b ");
for (int i = 0; i < c; i++)
{
    Console.Write($"{b[i]} ");
}

