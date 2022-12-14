// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] FillArray(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int IntCount(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)

        if (arr[i] >= 0)
            count++;
            
    return count;
    Console.WriteLine();
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(IntCount(arr_1));