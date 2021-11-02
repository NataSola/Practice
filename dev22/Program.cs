int index = 0;
int[] A = new int[25];
while (index < 25)
{
    A[index] = new Random().Next(-25, 26);
    index++;
}

index = 0;
while (index < 25)
{
    int val = A[index];
    Console.Write(val + " ");
    index++;
}
Console.WriteLine();

int current = A[0];
Console.Write(current + " ");
index = 1;
while (index <= 24)
{
    if (A[index] > current)
    {
        current = A[index];
        Console.Write(current + " ");
        //index++;
    }
    //Console.Write(A[index]);
    index++;
}
