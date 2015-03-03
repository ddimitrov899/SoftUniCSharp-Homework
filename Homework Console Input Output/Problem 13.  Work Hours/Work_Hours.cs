using System;

class Work_Hours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        double perecentOfP = p / 100.0;
        double biking = d * 0.1;
        biking = (d - biking) * 12.0;
        double productivity = biking * perecentOfP;
        int productivityHours = (int)productivity;
        double completeTheProject = productivityHours - h;
        if (completeTheProject < 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine((int)completeTheProject);
    }
}
