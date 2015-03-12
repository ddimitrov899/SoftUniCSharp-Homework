using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string DNALeter = Console.ReadLine().ToUpper();
        var simbol = DNALeter[0];
        int DNA = 0;
        int DNASimbol = 1;
        int width = 7;
        int dot = width / 2;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (count == width)
            {
                count = 0;
                DNASimbol += 2;
                dot--;
            }
            for (int dots = 0; dots < dot; dots++)
            {
                Console.Write('.');
            }
            for (int idex = DNA; idex < DNASimbol; idex++)
            {
                Console.Write(simbol);
                if (simbol < 'G')
                {
                    simbol++;
                }
                else
                {
                    simbol = 'A';
                }
            }
            for (int dots = 0; dots < dot; dots++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            if (count < dot + 2)
            {
                DNASimbol += 2;
                dot--;
            }
            else
            {
                DNASimbol -= 2;
                dot++;
            }
            count++;
        }
    }
}
