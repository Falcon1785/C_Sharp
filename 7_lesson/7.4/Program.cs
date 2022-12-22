// Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.

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

void ElPosition(int[,] arr, int num)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (arr[i, j] == num)
            {
                Console.WriteLine($"Позиция элемента по горизонтали:{j + 1}, по вертикали: {i + 1}");
                return;
            }
    }
    Console.WriteLine("Такого элемента в массиве нет");
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("from: ");
int from = int.Parse(Console.ReadLine());
Console.WriteLine("to: ");
int to = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column, from, to);
Print(arr_1);
Console.WriteLine("Введите элемент: ");
int num = int.Parse(Console.ReadLine());
ElPosition(arr_1, num);

// =========== Вариант с семинара =============

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
string FindElem(int[,] arr, int findNum)
{
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
if (arr[i, j] == findNum)
return $"Искомый элемент {findNum} находится на позиции [{i + 1}, {j + 1}]";
return $"Искомый элемент {findNum} не найден";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(FindElem(arr_1, int.Parse(Console.ReadLine())));