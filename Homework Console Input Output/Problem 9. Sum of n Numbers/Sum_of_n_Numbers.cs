using System;

class Sum_of_n_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double i = 0;
        double sum = 0;
        while (i < n)
        {
            double num = double.Parse(Console.ReadLine());
            i++;
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
