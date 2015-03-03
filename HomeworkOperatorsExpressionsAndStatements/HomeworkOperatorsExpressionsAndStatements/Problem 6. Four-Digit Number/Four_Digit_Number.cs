using System;

class Four_Digit_Number
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        /*
         * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
         * Calculates the sum of the digits (in our example 2+0+1+1 = 4).
         * Prints on the console the number in reversed order: dcba (in our example 1102).
         * Puts the last digit in the first position: dabc (in our example 1201).
         * Exchanges the second and the third digits: acbd (in our example 2101).
         * The number has always exactly 4 digits and cannot start with 0. Examples:
         */

        int d = num % 10;
        int c = (num / 10) % 10;
        int b = (num / 100) % 10;
        int a = (num / 1000) % 10;

        Console.WriteLine(a+b+c+d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

