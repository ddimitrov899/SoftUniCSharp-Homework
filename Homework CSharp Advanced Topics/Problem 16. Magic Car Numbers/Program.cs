using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 40;
        char[] XY = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int count = 0;
        for (int a = 0; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    for (int d = 0; d < 10; d++)
                    {

                        for (int magicStart = 0; magicStart < XY.Length; magicStart++)
                        {


                            for (int magicEnd = 0; magicEnd < XY.Length; magicEnd++)
                            {
                                sum += a + b + c + d;
                                sum += ((XY[magicEnd] - 64) * 10);
                                sum += ((XY[magicStart] - 64) * 10);
                                if (num == sum)
                                {
                                    if ((a == b && a == c && a == d)
                                        || (a != b && a != c && a != d && b == c && b == d)
                                        || (a == b && a == c && a != d)
                                        || (a == b && c == d && a != d)
                                        || (a != b && a == c && b == d)
                                        || (a != b && b == c && a == d))
                                    {
                                        //Console.WriteLine("CA{0}{1}{2}{3}{4}{5}", a, b, c, d, XY[magicStart], XY[magicEnd]);
                                        count++;
                                    }

                                }
                                else
                                {
                                    sum = 40;
                                }
                            }

                        }
                    }
                }
            }

        }
        Console.WriteLine(count);


    }
}

