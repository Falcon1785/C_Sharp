// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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

int SumOddPos(int[] arr)
{
    // int sum = 0;
    // for (int i = 0; i < arr.Length; i++)
    //     if (i % 2 != 0)
    //         sum += arr[i];
    // return sum;

    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}

int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(SumOddPos(arr_1));