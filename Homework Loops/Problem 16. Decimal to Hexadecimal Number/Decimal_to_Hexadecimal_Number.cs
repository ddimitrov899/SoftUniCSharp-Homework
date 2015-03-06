using System;
using System.Globalization;

class Decimal_to_Hexadecimal_Number
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());

        string hexaStr = dec.ToString("X");

        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

        Console.WriteLine(hexaStr);
    }
}
