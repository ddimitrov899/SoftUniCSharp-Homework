using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int meter = 0;
        int count = 0;
        for (int i = 0; i < num; i++)
        {
            int cabelLenth = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                cabelLenth = cabelLenth * 100;

            }
            if (cabelLenth >= 20)
            {
                sum += cabelLenth;
                count++;
            }



        }
        meter = 0;
        meter = (sum - 3 * (count - 1)) % 504;
        sum = (sum - 3 * (count - 1)) / 504;
        Console.WriteLine(sum);
        Console.WriteLine(meter);

    }
}
