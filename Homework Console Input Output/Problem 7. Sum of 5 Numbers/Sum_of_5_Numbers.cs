using System;

class Sum_of_5_Numbers
{
    static void Main(string[] args)
    {
        string[] num = Console.ReadLine().Split(' ');
        double a = double.Parse(num[0]);
        double b = double.Parse(num[1]);
        double c = double.Parse(num[2]);
        double d = double.Parse(num[3]);
        double e = double.Parse(num[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine(sum);
    }
}
