// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] array, int start, int end)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end);
    }    
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод масcива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];
    }
    return sum;
}

void Zadacha36 ()
{
    Random random = new Random();
    int size = 7;
    int[] array = new int[size];
    int start = 0;
    int end = 10;
    
    FillArray(array, start, end);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine(SumEvenIndex(array));
}

Zadacha36();