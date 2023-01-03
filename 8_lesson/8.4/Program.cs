// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

// =================== Свой вариант 

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

void ExcludeRC(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_i = 0;
    int min_j = 0;
    int min = arr[0, 0];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                min_i = i;
                min_j = j;
            }
            if (i + 1 == row && j + 1 == column)
            {
                for (int k = 0; k < row; k++)
                {
                    for (int l = 0; l < column; l++)

                        if (k != min_i && l != min_j)
                            Console.Write($"{arr[k, l],4} ");
                    Console.WriteLine();
                }
            }
        }
    }
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
ExcludeRC(arr_1);

// ================= Yakov

int[,] arr = new int[4, 4];
	        arr = DNPTools.FillIntMatrix(arr, 0, 9);
	        DNPTools.PrintArr(arr);
	        (int, int) minIndex = (0, 0);
	        for (int i = 0; i < arr.GetLength(0); i++)
	            for (int j = 0; j < arr.GetLength(1); j++)
	                if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
	        for (int i = 0; i < arr.GetLength(0); i++)
	        {
	            for (int j = 0; j < arr.GetLength(1); j++)
	            {
	                if (i == minIndex.Item1 | j == minIndex.Item2) continue;
	                Console.Write($"{arr[i, j]} ");
	            }
	            Console.WriteLine();
	        }

// ============== Две функции

int[] MinEl(int[,] arr)
	{
	    int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
	    int min_num = arr[0, 0];
	    int[] indexes = new int[2];
	
	    for (int i = 0; i < row; i++)
	    {
	        for (int j = 0; j < column; j++)
	            if (min_num > arr[i, j])
	            {
	                min_num = arr[i, j];
	                indexes[0] = i;
	                indexes[1] = j;
	            }
	    }
	    Console.WriteLine(arr[indexes[0], indexes[1]]);
	    return indexes;
	}
	
	void WithoutRowColumn(int[,] arr, int[] m_indexes)
	{
	    int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
	    
	    for (int i = 0; i < row; i++)
	    {
	        for (int j = 0; j < column; j++)
	            if (m_indexes[0] == i || m_indexes[1] == j) continue;
	            else Console.Write($"{arr[i, j],3}");
	        Console.WriteLine();
	    }
	    Console.WriteLine();
	}