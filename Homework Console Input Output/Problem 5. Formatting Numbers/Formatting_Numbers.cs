using System;

class Formatting_Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string hexA = a.ToString("X").PadRight(10,' ');
        string binA = Convert.ToString(a,2).PadLeft(10,'0');

        Console.WriteLine("|{0}|{1}|{2,10:0.##}|{3,-10:0.###}|",hexA,binA,b,c);

    }
}
