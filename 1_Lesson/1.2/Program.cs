// Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.

Console.WriteLine("Write a number:");

int num = int.Parse(Console.ReadLine());

if(num == 1)
{
    Console.WriteLine("Понедельник");
}
else if(num == 2)
{
    Console.WriteLine("Вторник");
}

else if(num == 3)
{
    Console.WriteLine("Среда");
}

else if(num == 4)
{
    Console.WriteLine("Четверг");
}
else if(num == 5)
{
    Console.WriteLine("Пятница");
}

else if(num == 6)
{
    Console.WriteLine("Суббота");
}

else if(num == 7)
{
    Console.WriteLine("Воскресенье");
}

else
    Console.WriteLine("Ошибка");