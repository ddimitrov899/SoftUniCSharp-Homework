using System;

class Odd_Even_Sum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int firstSum = 0;
        int secSum = 0;
        bool odd = true;
        for (int a = 0; a < num * 2; a++)
        {
            if (odd)
            {
                int firstNum = int.Parse(Console.ReadLine());
                firstSum += firstNum;
            }
            else
            {
                int secNum = int.Parse(Console.ReadLine());
                secSum += secNum;
            }
            odd = !odd;
        }
        if (firstSum == secSum)
        {
            Console.WriteLine("Yes, sum="+firstSum);
        }
        else
        {
            int diff = firstSum - secSum;
            diff = Math.Abs(diff);
            Console.WriteLine("No, diff="+diff);
        }
        
    }
}

