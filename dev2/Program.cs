// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания, 2-элементы больше 8, 3-знакочередование

int[] A = new int[10];
int[] B = new int[10];


void FillArray(int[] array)    // Создать массив А со случайными значениями от -100 до 100
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-100, 101);
        index++;
    }
}

void PrintArray(int[] coll)    // Напечатать массив A
{
    int count = coll.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{coll[i]} ");
    }
    Console.WriteLine();
}



//void FillArrayB(int[] A)
//{
  //  int count = 0;           //длина
    //int number = A[0];
//    for (int i = 0; i < A.Length; i++)     //перебираем массив А
  //  {
    //    if (A[i] > number) number = A[i];
      //  {
        //    B[count++] = A[i];
        //}
//    }
//}




//int current = A[2];
//Console.WriteLine(current + " ");

FillArray(A);
PrintArray(A);
//FillArrayB(B);
PrintArray(B);




