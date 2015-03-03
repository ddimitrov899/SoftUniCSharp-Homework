using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int totalWeekends = 48;
        int hometown = h;
        double weekends = totalWeekends - h;
        double normalWekends = weekends * 3.0 / 4;
        double holidays = p * 2.0 / 3;
        double total = hometown + normalWekends + holidays;
        if (leap == "leap")
        {
            total = total * 1.15;
        }
        Console.WriteLine((int)total);

    }
}

