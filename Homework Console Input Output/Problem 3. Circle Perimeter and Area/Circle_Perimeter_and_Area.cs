using System;

class Circle_Perimeter_and_Area
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("Perimeter: {0:0.00} \nArea: {1:0.00}",perimeter,area);
    }
}
