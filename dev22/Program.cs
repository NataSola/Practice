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
Console.WriteLine("20 чисел от -25 до +25:");
while (index < 20)
{
    int val = A[index];
    Console.Write(val + " ");
    index++;
}
Console.WriteLine();

// Выводим на печать элементы массива, не нарушающие порядок возрастания 

int current = A[0];
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
