using System;

class Divide_by_7_and_5
{
    static void Main()
    {
        // Write a Boolean expression that checks for given integer 
        //if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
        int num = int.Parse(Console.ReadLine());
        bool numDevided = num % 5 == 0 && num % 7 == 0;
        
        Console.WriteLine(numDevided);
    }
}

