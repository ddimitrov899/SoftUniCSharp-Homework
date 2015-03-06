using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int faktN = 1;
        int faktK = 1;
        int result = 0;

        for (int i = 1; i <= n; i++)
        {
            faktN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            faktK *= i;
        }
        result += faktN / faktK;
        Console.WriteLine(result);
    }
}
