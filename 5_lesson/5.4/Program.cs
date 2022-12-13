//  Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

//=============== Свой вариант =================

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

int[] Mult(int[] arr)
{
    int size = arr.Length;
    int j = size - 1;
    int[] arr_new = new int[size - size / 2];

    for (int i = 0; i < size / 2; i++)
    {
        arr_new[i] = arr[i] * arr[j];
        j--;
    }
    if (size % 2 != 0)
        arr_new[arr_new.Length - 1] = arr[size / 2];
    return arr_new;
}


int[] arr_1 = FillArray(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Print(Mult(arr_1));

//=========== Вариант 2 ===========

void Print(int[] arr)
	{
	    int size = arr.Length;
	
	    for (int i = 0; i < size; i++)
	        Console.Write($"{arr[i]} ");
	    Console.WriteLine();
	}
	
	int[] MassNums(int size)
	{
	    int[] arr = new int[size];
	
	    for (int i = 0; i < size; i++)
	        arr[i] = new Random().Next(1, 11);
	    return arr;
	}
	
	int[] PairsNum(int[] arr)
	{
	    int size = arr.Length;
	    int flex_size = size / 2 + size % 2;
	    int[] new_arr = new int[flex_size];
	
	    for (int i = 0; i < size / 2; i++)
	        new_arr[i] = arr[i] * arr[size - i - 1];
	
	    if (new_arr[flex_size - 1] == 0)
	        new_arr[flex_size - 1] = arr[flex_size - 1];
	    return new_arr;
	}
	
	int[] arr_1 = MassNums(5);
	Print(arr_1);
	int[] arr_1_new = PairsNum(arr_1);
	Print(arr_1_new);