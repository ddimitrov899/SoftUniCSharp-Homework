using System;
using System.Timers;
class Difference_between_Dates
{
    static void Main()
    {
        DateTime dateStart = DateTime.Parse(Console.ReadLine());
        DateTime dateEnd = DateTime.Parse(Console.ReadLine());
        var totalDay = (dateEnd - dateStart).TotalDays;
        Console.WriteLine(totalDay);
    }
}

