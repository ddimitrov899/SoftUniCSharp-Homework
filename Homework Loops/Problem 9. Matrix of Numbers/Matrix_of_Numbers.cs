using System;

class Matrix_of_Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int colon = 1;
        int num = n;
        if (n >= 20 || n <= 1)
        {
            Console.WriteLine("No Matrix !!!");
        }
        else
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = colon; col <= num; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
                colon++;
                num++;
                if (colon == n + 1)
                {
                    break;
                }
            }
        }
    }
}
