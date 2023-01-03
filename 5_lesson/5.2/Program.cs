// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

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

string FindDig(int[] arr, int find)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
            return "Yes";
    }
    return "No";        
}
int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Enter the number your are looking for:");
Console.WriteLine(FindDig(arr_1, int.Parse(Console.ReadLine())));