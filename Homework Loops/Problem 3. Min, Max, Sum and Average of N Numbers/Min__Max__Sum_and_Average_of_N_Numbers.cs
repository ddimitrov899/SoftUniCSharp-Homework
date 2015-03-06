using System;

class Min__Max__Sum_and_Average_of_N_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
            avg = sum / n;
        }
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", avg);

    }
}
