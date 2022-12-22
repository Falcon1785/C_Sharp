//  Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] arr)

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

double[,] FillArray(int row, int column, double from, double to)

{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round((new Random().NextDouble() * (to - from) + from), 2);
    return arr;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("range from: ");
double from = int.Parse(Console.ReadLine());
Console.WriteLine("range to: ");
double to = int.Parse(Console.ReadLine());
double[,] arr_1 = FillArray(row, column, from, to);
Print(arr_1);