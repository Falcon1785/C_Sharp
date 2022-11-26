// Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
int X = 2;

while(X <= N)
{

Console.Write($"{X} ");
X = X + 2;
}
