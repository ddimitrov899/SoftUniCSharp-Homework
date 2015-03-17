using System;

class Prime_Checker
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        bool numPrime = IsPrime(num);
        Console.WriteLine(numPrime);
    }

    static bool IsPrime(long n)
    {
        long primeNum = (long)Math.Sqrt(n);
        bool numPrime = true;
        for (int i = 2; i <= primeNum; i++)
        {
            if (n % i == 0)
            {
                numPrime = false;
                break;
            }

        }
        if (n < 2)
        {
            numPrime = false;
        }
        return numPrime;
    }
}
