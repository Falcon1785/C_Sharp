// Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
//два без остатка).

Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine());

if(num1 % 2 == 0) Console.WriteLine("четное число");
else              Console.WriteLine("нечетное число");