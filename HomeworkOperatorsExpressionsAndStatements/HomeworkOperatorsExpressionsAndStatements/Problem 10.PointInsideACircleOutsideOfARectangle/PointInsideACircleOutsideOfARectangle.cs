using System;

    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            /*
             * Write an expression that checks for given point (x, y) 
             * if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
             */
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool insideK = ((Math.Pow(x-1,2)) + (Math.Pow(y-1,2)) <= 1.5 + 1.5);
            bool insideR = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
            if (insideK  && !insideR )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
