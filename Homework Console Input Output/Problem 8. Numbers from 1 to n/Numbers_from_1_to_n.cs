using System;

class Numbers_from_1_to_n
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
