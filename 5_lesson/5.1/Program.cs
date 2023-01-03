// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void Switch(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // if (arr[i] > 0)
        // {
        //     arr[i] = arr[i] - arr[i] * 2;
        //     Console.Write($"{arr[i]} ");
        // }
        // else
        // {
        //     arr[i] = arr[i] * -1;
        //     Console.Write($"{arr[i]} ");
        // }
        arr[i] *= -1;
        //Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Switch(arr_1);
Print(arr_1);