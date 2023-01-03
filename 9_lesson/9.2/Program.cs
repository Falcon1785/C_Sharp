// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void NatNumBtw(int M, int N)
{
    if (M > N) return;
    Console.Write($"{M} ");
    NatNumBtw(M + 1, N);
}
NatNumBtw(4, 8);
Console.WriteLine();