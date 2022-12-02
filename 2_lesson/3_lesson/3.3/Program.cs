// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// Свой вариант

void List(int N)
{
    int i = 1;

    while (i <= N)
    {
        if (i == N)
        {
            Console.WriteLine($"{Math.Pow(i, 2)} ");
        }
        else
        {
            Console.Write($"{Math.Pow(i, 2)}, ");
        }
        i++;
    }
}
Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine());
List(N);

// Вариант из семинара

void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N)
    {
        i += 1;
        if (i == (N))
        {
            pere = Math.Pow(i, 2);
            Console.WriteLine($"{pere}");
        }
        else
        {

            pere = Math.Pow(i, 2);
            Console.Write($"{pere},");
        }
    }
}
Console.WriteLine("введите ч");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);



