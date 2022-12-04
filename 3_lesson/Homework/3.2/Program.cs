// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void List(int N)
{
    int i = 1;
    if (N > 0)

        while (i <= N)
        {
            if (i == N)
            {
                Console.WriteLine($"{Math.Pow(i, 3)} ");
            }
            else
            {
                Console.Write($"{Math.Pow(i, 3)}, ");
            }
            i++;
        }
    else
        while (i >= N)
        {
            if (i == N)
            {
                Console.WriteLine($"{Math.Pow(i, 3)} ");
            }
            else
            {
                Console.Write($"{Math.Pow(i, 3)}, ");
            }
            i--;
        }
}
Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine());
List(N);
