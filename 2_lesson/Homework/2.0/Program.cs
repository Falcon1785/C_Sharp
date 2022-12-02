//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//Console.WriteLine((num / 100) * 10 + num % 10);

int DelMiddle(int num)
{
    return (num / 100) * 10 + num % 10;
}
int numnew = new Random().Next(100, 1000);
Console.WriteLine(numnew);
Console.WriteLine(DelMiddle(numnew));