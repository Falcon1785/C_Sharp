// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

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

int[,] MultMatrix(int[,] arr_1, int[,] arr_2)
{
    int row = arr_1.GetLength(0);
    int column = arr_1.GetLength(1);
    int[,] matrixmult = new int[row, column];

    if (row != arr_2.GetLength(0) || column != arr_2.GetLength(1))
        return matrixmult;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matrixmult[i, j] = arr_1[i, j] * arr_2[i, j];
    return matrixmult;
}

Console.WriteLine("Enter the number of rows in matrix_1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns in matrix_1: ");
int column_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of rows in matrix_2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns in matrix_2: ");
int column_2 = int.Parse(Console.ReadLine());

Console.WriteLine("range from: ");
int from = int.Parse(Console.ReadLine());
Console.WriteLine("range to: ");
int to = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row_1, column_1, from, to);
Print(arr_1);
int[,] arr_2 = FillArray(row_2, column_2, from, to);
Print(arr_2);

Print(MultMatrix(arr_1, arr_2));