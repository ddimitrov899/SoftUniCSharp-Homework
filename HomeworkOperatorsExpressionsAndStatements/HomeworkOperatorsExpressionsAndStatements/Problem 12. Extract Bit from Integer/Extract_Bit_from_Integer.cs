using System;

class Extract_Bit_from_Integer
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p. Examples:

        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}
