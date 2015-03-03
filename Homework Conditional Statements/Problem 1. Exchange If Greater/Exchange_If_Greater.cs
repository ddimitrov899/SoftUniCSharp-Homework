using System;

class Exchange_If_Greater
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secNum = double.Parse(Console.ReadLine());


        if (firstNum < secNum)
        {
            Console.WriteLine("{0} {1}", firstNum, secNum);
        }
        else
        {
            Console.WriteLine("{0} {1}", secNum, firstNum);
        }
    }
}
