using System;

class Multiplication_Sign
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        double sum = numA * numB * numC;
        if (sum > 0)
        {
            Console.WriteLine("+");
        }
        else if (sum < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
