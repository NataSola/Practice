// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания, 2-элементы больше 8, 3-знакочередование


void FillArray(int[] collection)    // Создать массив А со случайными значениями от -100 до 100
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 101);
        index++;
    }
}

void PrintArray(int[] coll)    // Напечатать массив A
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(coll[position] + " ");
        position++;
    }
}


int[] A = new int[25];

//int current = A[2];
//Console.WriteLine(current + " ");

FillArray(A);
PrintArray(A);



