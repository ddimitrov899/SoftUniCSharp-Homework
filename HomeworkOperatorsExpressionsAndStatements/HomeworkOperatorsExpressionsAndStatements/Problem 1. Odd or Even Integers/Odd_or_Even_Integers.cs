using System;

class Odd_or_Even_Integers
{
    static void Main()
    {
        // Write an expression that checks if given integer is odd or even. Examples:
        int num = int.Parse(Console.ReadLine());
        bool check = num % 2 == 0;
        Console.WriteLine(check);
    }
}
