using System;
using System.Collections.Generic;
using System.Linq;

class Primes_in_Given_Range
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        List<int> findPrimeInRange = FindPrimeInRange(endNum, startNum);
        findPrimeInRange.ForEach(c => Console.Write(c + " "));
        Console.WriteLine();
    }

    private static List<int> FindPrimeInRange(int endNum, int startNum)
    {
        List<int> findPrimeInRange = new List<int>();
        
        int counter = 0;
        
        if (startNum < 0 || endNum < 0)
        {
            startNum = 2;
        }
        if (startNum == 0 || startNum == 1)
        {
            startNum = 2;
        }
        if (startNum > endNum)
        {
            Console.WriteLine("Empty list");
        }
        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                }
                if (counter > 2)
                {
                    break;
                }
            }
            if (counter <= 2)
            {
                findPrimeInRange.Add(i);
            }
            counter = 0;
        }
        
        return findPrimeInRange;
    }
}

