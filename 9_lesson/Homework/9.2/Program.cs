// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNums(int M, int N)
{
    if(M > N) return 0;
    return SumNums(M + 1, N) + M;
}

Console.WriteLine(SumNums(4, 8));