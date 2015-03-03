using System;

class Prime_Number_Check
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:

        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num > 1) 
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) 
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine(false);
        }
        
    }
}
