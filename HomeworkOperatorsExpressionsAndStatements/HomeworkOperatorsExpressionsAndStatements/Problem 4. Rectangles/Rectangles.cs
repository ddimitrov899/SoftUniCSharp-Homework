using System;

class Rectangles
{
    static void Main()
    {
        //  Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("{0}\n{1}",perimeter,area);
    }
}
