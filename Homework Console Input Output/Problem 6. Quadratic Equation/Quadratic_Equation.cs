using System;

class Quadratic_Equation
{
    static void Main()
    {
        double a, b, c;
        //  ax^2 + bx + c = 0
        
        bool aIsValid = double.TryParse(Console.ReadLine(), out a);

        bool bIsValid = double.TryParse(Console.ReadLine(), out b);

        bool cIsValid = double.TryParse(Console.ReadLine(), out c);

        if (aIsValid && bIsValid && cIsValid)
        {
            //D = b^2 - 4*a*c
            double d = b * b - (4 * a * c);
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (double.IsNaN(x1) && double.IsNaN(x2))
            {
                Console.WriteLine("No real roots.");
            }
            else
            {
                Console.WriteLine("{0} {1}", x2, x1);
            }
        }
        else
        {
            Console.WriteLine("Please enter valid data.");
            Console.Beep();
        }
    }
}

