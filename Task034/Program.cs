// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
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

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void Zadacha34 ()
{
    Random random = new Random();
    int size = 7;
    int[] array = new int[size];
    
    FillArray(array);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine(EvenNumbers(array));
}

Zadacha34();


