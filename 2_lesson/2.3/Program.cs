// Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно
//7 и 23.

string Mult(int num)
{
if(num % 7 == 0)
    if(num % 23 == 0)
        return "Да";
    else 
        return "Нет";
else
    return "Нет";         
}
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Mult(num));