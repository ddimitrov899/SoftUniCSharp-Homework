using System;

class Bits_Exchange
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:

        uint numBit = uint.Parse(Console.ReadLine());

        uint mask = 7;
        uint firstBits = (numBit & (mask << 3)) >> 3;
        uint secondBits = (numBit & (mask << 24)) >> 24;

        numBit = numBit & ~(mask << 3);
        numBit = numBit & ~(mask << 24);

        numBit = numBit | (firstBits << 24);
        numBit = numBit | (secondBits << 3);
        Console.WriteLine(numBit);

    }
}

