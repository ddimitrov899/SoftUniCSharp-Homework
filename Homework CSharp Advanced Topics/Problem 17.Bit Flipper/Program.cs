using System;


class Program
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        ulong mask = 7;
        int numBits = 62;
        while (numBits > 0)
        {
            numBits--;
            ulong treeBits = (num >> numBits) & mask;
            if (treeBits == 0 || treeBits == mask)
            {
                num = num ^ ( mask << numBits);
                numBits -= 2;
            }
        }
            
        
        Console.WriteLine(num);
    }
}

