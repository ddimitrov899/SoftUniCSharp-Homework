using System;

class The_Biggest_of_3_Numbers
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if (numA > numB)
        {
            if (numA > numC)
            {
                Console.WriteLine(numA);
            }
            else
            {
                Console.WriteLine(numC);
            }
        }
        else
        {
            if (numB > numC)
            {
                Console.WriteLine(numB);
            }
            else
            {
                Console.WriteLine(numC);
            }
        }
    }
}
