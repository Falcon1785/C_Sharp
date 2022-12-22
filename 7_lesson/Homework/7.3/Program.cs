// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

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

void Average(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double sum = 0;
    int j = 0;
    while (j < column)
    {
        for (int i = 0; i < row; i++)
        {
            sum = sum + arr[i, j];
        }
        Console.Write($"{Math.Round((sum / row), 2)} ");
        sum = 0;
        j++;
    }
    Console.WriteLine();
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
Average(arr_1);
