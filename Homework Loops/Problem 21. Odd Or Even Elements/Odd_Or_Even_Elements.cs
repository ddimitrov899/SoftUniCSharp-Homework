using System;

class Odd_Or_Even_Elements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        string[] n = Console.ReadLine().Split(' ');
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        for (var i = 0; i < n.Length; i++)
        {
            decimal num = decimal.Parse(n[i]);
            if (i % 2 == 0)
            {
                oddMin = Math.Min(oddMin, num);
                oddMax = Math.Max(oddMax, num);
                oddSum += num;

            }
            else
            {
                evenMin = Math.Min(evenMin, num);
                evenMax = Math.Max(evenMax, num);
                evenSum += num;
            }
        }
        if (n.Length <= 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }

    }
}
