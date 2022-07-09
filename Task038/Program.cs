// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(double[] array, int start, int end)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end);
    }    
}

void PrintArray(double[] array)
{
    Console.WriteLine("Вывод масcива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = max - min;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        diff = max - min;
    }
    return diff;
}

void Zadacha36 ()
{
    Random random = new Random();
    int size = 7;
    double[] array = new double[size];
    int start = 0;
    int end = 100;
    
    FillArray(array, start, end);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine(MaxMinDiff(array));
}

Zadacha36();