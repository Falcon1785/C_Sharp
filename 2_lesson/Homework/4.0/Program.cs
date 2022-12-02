// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int num = int.Parse(Console.ReadLine());
if(num < 6 && num > 0)
{
    Console.WriteLine("Business day");
}
else
    if(num > 5 && num < 8)

        Console.WriteLine("Day off");
    else
        Console.WriteLine("Wrong number");
