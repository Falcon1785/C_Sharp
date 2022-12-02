//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деления.

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//if(num1 % num2 == 0)
//{
  //  Console.WriteLine("Кратно");
//}
//else
  //  Console.WriteLine($"Не кратно, остаток - {num1 % num2}");

string Mult(int num1, int num2)
{
if(num1 % num2 == 0)
     return "Кратно";
else
    return $"некратно, остаток = {num1 % num2}";
}
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Mult(num1, num2));

