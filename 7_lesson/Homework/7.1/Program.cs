// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

string FindElm(int[,] arr, int pos_1, int pos_2)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (pos_1 > row || pos_2 > column)
    {
        return $"В данном массиве такого элемента не существует";
    }
    else if (pos_1 <= 0 || pos_2 <= 0)
    {
        return $"В данном массиве такого элемента не существует";
    }
    else
        return $"Значение элемента на заданных позициях -> {arr[(pos_1 - 1), (pos_2 - 1)]}";
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
Console.WriteLine("Enter position 1: ");
int pos_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter position 2: ");
int pos_2 = int.Parse(Console.ReadLine());
Console.WriteLine(FindElm(arr_1, pos_1, pos_2));