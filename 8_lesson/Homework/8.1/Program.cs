// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)

            Console.Write($"{arr[i, j],4} ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column, int from, int to)

{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int[,] SortArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("range from: ");
int from = int.Parse(Console.ReadLine());
Console.WriteLine("range to: ");
int to = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column, from, to);
Print(arr_1);
int[,] arr_2 = SortArray(arr_1);
Print(arr_2);