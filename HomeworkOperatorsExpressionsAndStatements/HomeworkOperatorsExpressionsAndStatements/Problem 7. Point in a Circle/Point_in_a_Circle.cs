using System;

class Point_in_a_Circle
{
    static void Main()
    {
        //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool check = (((x * x) + (y * y)) <= 2 * 2);
        Console.WriteLine(check);
    }
}
