using System;

class Bitwise_Extract_Bit_Sharp_3
{
    static void Main()
    {
        /*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
         * The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:
         */
        int p = 3;
        uint n = uint.Parse(Console.ReadLine());              
        uint nRightP = n >> p;      
        uint bit = nRightP & 1;     
        Console.WriteLine(bit);
    }
}
