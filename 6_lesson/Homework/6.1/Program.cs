// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNums(int num)
{
    int[] arr = new int[num];
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i + 1} : ");
        arr[i] = int.Parse(Console.ReadLine());
        if (arr[i] > 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0 - {CountNums(num)}");


//========== Вариант 2 ============

int count = 0;
while (true)
{
    Console.WriteLine("Введите числo");
    string x = Console.ReadLine();
    if (x == "")
    
    {
        Console.WriteLine($"Количество чисел больше 0 - {count}");
        return;
    }

    int num = int.Parse(x);
    if (num > 0)
    {
        count++;
    }
}
