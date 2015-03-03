using System;
using System.Globalization;

class Beer_Time
{
    static void Main()
    {
        DateTime beerTime = DateTime.Parse(Console.ReadLine().ToUpper());
       // convert and review what is the ending of time
        string sign = beerTime.ToString("tt", CultureInfo.InvariantCulture); 

        if (beerTime.Hour < 12)
        {
            if (sign == "AM")
            {
                if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
        }
        else
        {
            if (beerTime.Hour - 12 >= 1)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

        }
    }
}