using System;

class Fibonacci_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countFibonaci = 0;
        int firstNum = 0;
        int secNum = 1;
        if (n == 1)
        {
            Console.WriteLine(firstNum);
        }
            
        else if (n < 3)
        {
            Console.Write(firstNum + " " + secNum);
            
        }
        else
        {
            Console.Write(firstNum + " " + secNum + " ");
            for (int i = 0; i < n - 2; i++)
            {
                    
                    countFibonaci = firstNum + secNum;
                    firstNum = secNum;
                    secNum = countFibonaci;
                    Console.Write(countFibonaci + " ");
            }

        }
        Console.WriteLine();
    }
}
