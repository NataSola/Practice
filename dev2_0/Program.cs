// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания
// 2-элементы, больше 8
// 3-знакочередования

int n = 25;
int[] arrayA = new int[n];


void FillArrayA(int[] array)
{
    //int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}




void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//int[] arrayA = new int[10];
// int[] arrayB = new int[10];

///

int c = 0;
int[] arrayB = new int[n];
for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] > 8)
    {
        arrayB[c++] = arrayA[i];
    }
}

//Console.Write("b ");


FillArrayA(arrayA);
PrintArray(arrayA);
Console.WriteLine();
//FillArrayB(arrayB);
// PrintArray(arrayB);


int current = arrayA[0];                         // определяем первый текущий элемент массива
Console.WriteLine();
Console.WriteLine("Элементы массива, не нарушающие порядок возрастания:");
Console.Write(current + " ");               // выводим первый текущий элемент массива на печать
//int index = 1;                                  // определяем первый проверяемый элемент массива (по индексу)
//while (index < 20) 
for (int index = 1; index < arrayA.Length; index++)                         // определяем условие цикла для каждого следующего элемента массива: пока индекс меьше 20
{
    if (arrayA[index] > current)                 // задаем условие: если элемент массива больше текущего элемента, то:
    {
        current = arrayA[index];                 // определяем новый текущий элемент
        Console.Write(current + " ");       // выводим новый текущий элемент на печать
    }

    //index++;                                // определяем следующий проверяемый элемент массива (по индексу)
}
Console.WriteLine();

///

int k = 0;
for (int i = 0; i < n; i++)
{
    if (arrayA[i] > 8)
    {
        arrayB[k++] = arrayA[i];

    }

}

Console.WriteLine(); Console.WriteLine("Элементы массива больше 8: ");
for (int i = 0; i < k; i++)
{
    Console.Write($"{arrayB[i]} ");
}

