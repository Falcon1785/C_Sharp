// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

//int Sum(int A)
//{
   // int i = 1;
    //int S = 0;
   // while (i <= A)
   // {
   //     S = S + i;
  //      i++;
  //  }
  //  return S;
//}

//Console.WriteLine(Sum(int.Parse(Console.ReadLine())));

int SumNums(int num)
	{
	    int all_sum = 0;
	    for (int i = 1; i <= num; i++)
	    {
	        all_sum += i;
	    }
	
	    return all_sum;
	}
	
	Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));

