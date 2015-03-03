using System;

class New_House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dash = n / 2;
        int asterix = 1;
        for (int roof = 0; roof < n / 2 + 1; roof++)
        {
            for (int dashRow = 0; dashRow < dash; dashRow++)
            {
                Console.Write('-');

            }

            for (int asterixRow = 0; asterixRow < asterix; asterixRow++)
            {
                Console.Write('*');

            }

            for (int dashRow = 0; dashRow < dash; dashRow++)
            {
                Console.Write('-');

            }
            Console.WriteLine();
            dash--;
            asterix += 2;
        }
        int pipe = 1;
        asterix = n - 2;
        for (int floor = 0; floor < n; floor++)
        {
            for (int pipeRow = 0; pipeRow < pipe; pipeRow++)
            {
                Console.Write('|');
            }
            for (int asterixRow = 0; asterixRow < asterix; asterixRow++)
            {
                Console.Write('*');
            }
            for (int pipeRow = 0; pipeRow < pipe; pipeRow++)
            {
                Console.Write('|');
            }
            Console.WriteLine();
        }


    }
}
