//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет. 

int num = int.Parse(Console.ReadLine());

if(num > 100)
{
    while(num > 999)
          {
            num = num / 10;
          }
int Dig3 = num % 10;
Console.WriteLine(Dig3);
}
else
    Console.WriteLine("Third digit is missing");    