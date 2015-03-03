using System;

class Check_a_Bit_at_Given_Position
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        if (bit == 1)
        {
            Console.WriteLine(true);            
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}
