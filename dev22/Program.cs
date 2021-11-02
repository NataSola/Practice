// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания
// 2-элементы, больше 8
// знакочередования

// Создаем массив, количество элементов 20, диапазон от -25 до 25 включительно
// заполняем массив случайными числами

int index = 0;
int[] A = new int[20];
while (index < 20)
{
    A[index] = new Random().Next(-25, 26);
    index++;
}

// Выводим массив на печать

index = 0;
Console.WriteLine();
Console.WriteLine("Массив из 20 чисел от -25 до +25 включительно:");
while (index < 20)
{
    int val = A[index];
    Console.Write(val + " ");
    index++;
}
Console.WriteLine();

// 1. Выводим на печать элементы массива, не нарушающие порядок возрастания 

int current = A[0];
Console.WriteLine();
Console.WriteLine("Элементы, не нарушающие порядок возрастания:");
Console.Write(current + " ");
index = 1;
while (index <= 19)
{
    if (A[index] > current)
    {
        current = A[index];
        Console.Write(current + " ");
    }
    index++;
}
Console.WriteLine();

// 2. Выводим на печать элементы массива, которые больше 8

Console.WriteLine();
Console.WriteLine("Элементы массива, которые больше 8:");
for (index = 0; index < 20; index++)
    if (A[index] > 8)
    {
        Console.Write(A[index] + " ");
    }
Console.WriteLine();

// 3. Выводим элементы, не нарушающие порядок знакочередования

Console.WriteLine();
Console.WriteLine("Элементы массива, не нарушающие порядок знакочередования:");
Console.Write(A[0] + " ");
int cur = A[0];
index = 1;
for (index = 0; index < 20; index++)
    if (cur < 0 && A[index] > 0)
    {
        cur = A[index];
        Console.Write(cur + " ");
    }
    else
        {
            if (cur > 0 && A[index] < 0)
            {
                cur = A[index];
                Console.Write(cur + " ");
            }
        }

Console.WriteLine();Console.WriteLine();
Console.WriteLine("The End");
Console.WriteLine();
