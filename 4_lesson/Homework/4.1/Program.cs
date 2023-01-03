// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNums(int num)
{
    int all_sum = 0;
    while (num > 0)
    {
        all_sum = all_sum + num % 10;
        num /= 10;
    }
    return all_sum;
}
Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));

// =============== Вариант 1 с разбора ДЗ ======================

int SumNums_1(int num)
{
    int n_sum = 0;

    for (int i = num; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}

Console.WriteLine(SumNums_1(int.Parse(Console.ReadLine())));

// ============== Вариант 2 с разбора ДЗ ===================

double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }

    return sum;
}

Console.WriteLine(DigitSum(int.Parse(Console.ReadLine())));