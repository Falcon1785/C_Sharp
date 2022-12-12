// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void FillShowArray(int N, int A,int B)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++) 
    {
        array[i] = new Random().Next(A, B);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Задайте количество элементов массива:");
int N = (int.Parse(Console.ReadLine()));
Console.WriteLine("Задайте минимальное число диапазона:");
int A = (int.Parse(Console.ReadLine()));
Console.WriteLine("Задайте максимальное число диапазона:");
int B = (int.Parse(Console.ReadLine()));
FillShowArray(N, A, B);
Console.WriteLine();

//=========== Правильный вариант с 2 функциями из разбора ДЗ ===============

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 100);
    return arr;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
int[] arr_2 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_2);