//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого
//числа.

//int num = int.Parse(Console.ReadLine());
//Console.WriteLine((num / 10) % 10);

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//Console.WriteLine((num / 10) % 10);

int MiddleD(int num)
{
    return ((num / 10) % 10);
}

Console.WriteLine(MiddleD(int.Parse(Console.ReadLine())));
