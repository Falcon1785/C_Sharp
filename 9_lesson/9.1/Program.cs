// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void NatNum(int N)
{
    if (N == 0) return;
    NatNum(N - 1);
    Console.Write($"{N} ");
}
NatNum(5);
Console.WriteLine();