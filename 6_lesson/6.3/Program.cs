// Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibbo(int N)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

Fibbo(int.Parse(Console.ReadLine()));
Console.WriteLine();
