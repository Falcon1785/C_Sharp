//Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную степень B.

int Expo(int A, int B)
{
    int all_mult = A;
    for (int count = 1; count < B; count++)
    {
        all_mult = all_mult * A;
    }
    return all_mult;
}

Console.WriteLine("enter A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("enter B:");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Expo(A, B));


