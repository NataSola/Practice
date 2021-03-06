// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания
// 2-элементы, больше 8
// 3-знакочередования

// Создаем массив, количество элементов 20, диапазон от -25 до 25 включительно
// заполняем массив случайными числами

int index = 0;                              // определяем начальный индекс массива
int[] A = new int[20];                      // содаем новый массив из 20 чисел
while (index < 20)                          // определяем условие цикла заполнения массива числами: пока индекс меньше 20
{
    A[index] = new Random().Next(-25, 26);  // заполняем элемент массива случайным числом из диапазона от -25 до 25 включительно
    index++;                                // определяем индекс следующего элемента массива
}

// Выводим массив на печать

index = 0;                                  // определяем индекс первого элемента массива, выводимого на печать
Console.WriteLine();
Console.WriteLine("Массив из 20 чисел от -25 до +25 включительно:");
while (index < 20)                          // задаем условие цикла выведения элементов массива на печать: пока индекс меньше 20
{
    int val = A[index];                     // определяем текущий элемент для вывода на печать
    Console.Write(val + " ");               // выводим на печать текущий элемент массива
    index++;                                // определяем индекс следующего элемента массива
}
Console.WriteLine();

// 1. Выводим на печать элементы массива, не нарушающие порядок возрастания 
// для этого каждый элемент сравниваем с предыдущим и включаем в список те, которые больше предыдущего

int current = A[0];                         // определяем первый текущий элемент массива
Console.WriteLine();                        
Console.WriteLine("Элементы массива, не нарушающие порядок возрастания:");
Console.Write(current + " ");               // выводим первый текущий элемент массива на печать
index = 1;                                  // определяем первый проверяемый элемент массива (по индексу)
while (index < 20)                          // определяем условие цикла для каждого следующего элемента массива: пока индекс меьше 20
{
    if (A[index] > current)                 // задаем условие: если элемент массива больше текущего элемента, то:
    {
        current = A[index];                 // определяем новый текущий элемент
        Console.Write(current + " ");       // выводим новый текущий элемент на печать
    }
    index++;                                // определяем следующий проверяемый элемент массива (по индексу)
}
Console.WriteLine();

// 2. Выводим на печать элементы массива, которые больше 8
// для этого сравниваем каждый элемент с числом 8, в список включаем те, которые больше 8

Console.WriteLine();
Console.WriteLine("Элементы массива, которые больше 8:");
for (index = 0; index < 20; index++)        // определяем цикл: для каждого следующего элемента массива, пока индекс меньше 20
    if (A[index] > 8)                       // задаем условие: если элемент массива больше 8, то:
    {
        Console.Write(A[index] + " ");      // выводим элемент на печать
    }
Console.WriteLine();

// 3. Выводим элементы, не нарушающие порядок знакочередования
// для этого одновременного сравниваем текущий и следующий элементы с 0

Console.WriteLine();
Console.WriteLine("Элементы массива, не нарушающие порядок знакочередования:");
Console.Write(A[0] + " ");                  // выводим на печать первый элемент массива 
int cur = A[0];                             // определяем первый текущий элемент
index = 1;                                  // определяем следующий элемент массива (по индексу)
for (index = 0; index < 20; index++)        // определяем цикл: для каждого следующего элемента массива, пока индекс меньше 20
                                            // тело цикла:
    if (cur < 0 && A[index] > 0)            // задаем первое условие: текущий элемент меньше 0 и следущий элемент больше 0
    {
        cur = A[index];                     // если первое условие выполняется, то определяем новый текущий элемент
        Console.Write(cur + " ");           // выводим новый текущий элемент на печать
    }
    else                                    // если первое условие не выполнено, то тогда:
        {
            if (cur > 0 && A[index] < 0)    // задаем второе условие: текущий элемент больше 0 и следующий элемент меньше 0
            {
                cur = A[index];             // если второе условие выполняется, то определяем новый текущий элемент
                Console.Write(cur + " ");   // выводим новый текущий элемент на печать
            }
        }

Console.WriteLine();Console.WriteLine();
Console.WriteLine("The End");
Console.WriteLine();
