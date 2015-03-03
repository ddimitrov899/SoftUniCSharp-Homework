using System;


class Sum_of_Elements
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(' ');

        long count = 0;
        long bigNum = 0;
        for (int i = 0; i < n.Length; i++)
        {

            int num = int.Parse(n[i]);
            count = count + num;
            if (num > bigNum)
            {
                bigNum = num;
            }
        }
        if (count == 2 * bigNum)
        {
            Console.WriteLine("Yes, sum=" + bigNum);
        }
        else
        {
            long diff = Math.Abs(count - 2 * bigNum);
            Console.WriteLine("No, diff=" + diff);
        }
    }
}
