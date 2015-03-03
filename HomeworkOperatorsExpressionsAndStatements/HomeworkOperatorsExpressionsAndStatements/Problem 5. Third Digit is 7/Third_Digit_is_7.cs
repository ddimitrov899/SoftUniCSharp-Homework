using System;

    class Program
    {
        // Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int thirdDigit = (num / 100) % 10;
            bool check = thirdDigit % 7 == 0;
            Console.WriteLine(check);
        }
    }
