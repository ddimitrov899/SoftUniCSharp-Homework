using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
        int count;
        for (int i = 2; i < 1001; i++)
        {
            if (i % 2 == 0)
            {
                count = i;
            }
            else
            {
                count = i * -1;
            }
            Console.WriteLine(count);
        }
    }
}

