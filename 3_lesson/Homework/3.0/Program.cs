// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

void Pal(int num)
{
    if (num > 9999 || num < 99999 && num > -99999 || num < -9999)
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
        Console.WriteLine($"{num} -> да");
    else
        Console.WriteLine($"{num} -> нет");
}
int num = int.Parse(Console.ReadLine());
Pal(num);