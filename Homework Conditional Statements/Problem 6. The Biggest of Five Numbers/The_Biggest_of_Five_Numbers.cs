using System;

class The_Biggest_of_Five_Numbers
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());
        double numD = double.Parse(Console.ReadLine());
        double numE = double.Parse(Console.ReadLine());

        if (numA > numB && numA > numC && numA > numD && numA > numE)
        {
            Console.WriteLine(numA);
        }
        else if (numE > numA && numE > numB && numE > numC && numE > numD)
        {
            Console.WriteLine(numE);
        }
        else if (numB > numC && numB > numD)
        {
            Console.WriteLine(numB);
        }
        else if (numC > numD)
        {
            Console.WriteLine(numC);
        }
        else
        {
            Console.WriteLine(numD);
        }
    }
}
