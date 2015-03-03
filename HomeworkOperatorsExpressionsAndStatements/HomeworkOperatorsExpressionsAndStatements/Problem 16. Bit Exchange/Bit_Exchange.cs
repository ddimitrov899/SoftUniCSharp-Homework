using System;

class Bit_Exchange
{
    static void Main()
    {
        /*
         * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
         * The first and the second sequence of bits may not overlap. Examples:
         */

        try //Try to exception
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (Math.Max(p, q) + k - 1 > 31)
            {
                Console.WriteLine("out of range");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;
                    uint firstBitsQ = (n & (mask << q)) >> q;
                    uint secondBitsP = (n & (mask << i)) >> i;

                    n = n & ~(mask << i);
                    n = n & ~(mask << q);

                    n = n | (firstBitsQ << i);
                    n = n | (secondBitsP << q);
                    q++;

                }
                Console.WriteLine(n);
            }
        }
        catch (Exception ex)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("out of range");

        }
    }
}

