// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void NaturEvenNum(int M, int N)
{
    if (M > N) return;
    if (M % 2 != 0)
        M++;
    Console.Write($"{M} ");
    NaturEvenNum(M + 2, N);
}

NaturEvenNum(4, 8);
Console.WriteLine();

// =======================================

void NaturEvenNum(int M, int N)
{
    if (M > N) return;
    if (M % 2 != 0)
    {
        M++;
        Console.Write($"{M} ");
        NaturEvenNum(M + 2, N);
    }
    else
    {
        Console.Write($"{M} ");
        NaturEvenNum(M + 1, N);
    }
}

NaturEvenNum(1, 5);
Console.WriteLine();