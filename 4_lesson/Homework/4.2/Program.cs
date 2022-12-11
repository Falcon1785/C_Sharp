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