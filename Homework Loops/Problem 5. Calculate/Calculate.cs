using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double s = 1;
        double factN = 1;
        double multiX = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            s += factN / multiX;
        }
        Console.WriteLine("{0:F5}" , s);
    }
}
