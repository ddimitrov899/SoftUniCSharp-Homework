using System;
using System.Numerics;
class Trailing_Zeroes_in_N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool check = false;
        BigInteger faturN = 1;
        BigInteger chekZiro = 0;
        int findZiro = 0;
        for (int fact = 1; fact <= n; fact++)
        {
            faturN *= fact;
            if (fact == n)
            {
                check = true;
            }
        }
        if (check = true)
        {
            for (int checkt = 1; checkt <= n; checkt++)
            {
                chekZiro = faturN % 10;
                faturN /= 10;
                if (chekZiro == 0)
                {
                    findZiro++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(findZiro);
        }

    }
}
