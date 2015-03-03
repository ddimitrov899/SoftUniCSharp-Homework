using System;

class Bonus_Score
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(score * 10);
                return;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(score * 100);
                return;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(score * 1000);
                return;
            default:
                Console.WriteLine("invalid score");
                return;
        }
    }
}
