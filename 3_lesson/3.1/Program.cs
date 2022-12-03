// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

//void Range(int quarter)
//{
//    if (quarter == 1)
//        Console.WriteLine("x > 0, y > 0");
//    else if (quarter == 2)
//        Console.WriteLine("x < 0, y > 0");
//    else if (quarter == 3)
//        Console.WriteLine("x < 0, y < 0");
//    else if (quarter == 4)
//        Console.WriteLine("x > 0, y < 0");
//    else
//        Console.WriteLine("Error");
//}
//Range(int.Parse(Console.ReadLine()));

void Range(string quarter)
{
    if (quarter == "1")
        Console.WriteLine("x > 0, y > 0");
    else if (quarter == "2")
        Console.WriteLine("x < 0, y > 0");
    else if (quarter == "3")
        Console.WriteLine("x < 0, y < 0");
    else if (quarter == "4")
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Error");
}
Range(Console.ReadLine());