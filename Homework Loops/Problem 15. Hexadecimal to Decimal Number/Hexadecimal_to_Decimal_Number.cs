using System;
using System.Globalization;

class Hexadecimal_to_Decimal_Number
{
    static void Main()
    {
        string hexa = Console.ReadLine();

        long dec = long.Parse(hexa, NumberStyles.HexNumber);

        Console.WriteLine(dec);
    }
}
