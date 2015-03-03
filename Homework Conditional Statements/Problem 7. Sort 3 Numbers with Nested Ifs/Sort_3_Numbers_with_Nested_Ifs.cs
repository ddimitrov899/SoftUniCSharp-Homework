using System;

class Sort_3_Numbers_with_Nested_Ifs
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if (numA > numB && numA > numC)
        {
            if (numB > numC)
            {
                Console.WriteLine("{0} {1} {2}", numA, numB, numC);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numA, numC, numB);
            }
        }
        else if (numB > numC && numB > numA)
        {
            if (numC > numA)
            {
                Console.WriteLine("{0} {1} {2}", numB, numC, numA);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numB, numA, numC);
            }
        }
        else
        {
            if (numC > numA && numB > numA)
            {
                Console.WriteLine("{0} {1} {2}", numC, numB, numA);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numC, numA, numB);
            }
        }
    }
}
