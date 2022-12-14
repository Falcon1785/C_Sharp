// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] FillArray(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round((new Random().NextDouble() * (to - from) + from), 2);
    return arr;
}

void MaxMinDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i + 1 < arr.Length; i++)
    {
        if (max < arr[i + 1]) max = arr[i + 1];
        if (min > arr[i + 1]) min = arr[i + 1];
    }
    Console.WriteLine($"{max} - ({min}) = {max - min}");
}

double[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
MaxMinDiff(arr_1);