// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

string MinSumRow(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int Sum1 = 0;

    for (int j = 0; j < column; j++)
    {
        Sum1 = Sum1 + arr[0, j];
    }
    for (int i = 1; i < row; i++)
    {
        int Sum2 = 0;
        for (int j = 0; j < column; j++)
        {
            Sum2 = Sum2 + arr[i, j];
        }
        if (Sum2 < Sum1)
            row = i;
    }
    return $"Строка с минимальной суммой элементов это строка номер {row + 1}";
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
Console.WriteLine(MinSumRow(arr_1));