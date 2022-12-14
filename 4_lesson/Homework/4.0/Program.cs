//Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную степень B.

int Expo(int A, int B)
{
    int mult = A;
    for (int count = 1; count < B; count++)
    {
        mult = mult * A;
    }
    return mult;
}

Console.WriteLine("enter A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B:");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Expo(A, B));

// =========== Вариант с разбора ДЗ с проверкой на отрицательную степень ============

Double PowNum(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a;
        else
            n_pow /= a;
    }
    return n_pow;
}
Console.WriteLine("enter a number: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter a degree of a number: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(PowNum(num_1, num_2));
