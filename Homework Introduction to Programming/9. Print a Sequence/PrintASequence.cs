using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintASequence
{
    static void Main()
    {
        int count;
        for (int sequence = 2; sequence < 11; sequence++)
        {
            if (sequence % 2 == 0)
            {
                count = sequence;
            }
            else
            {
                count = sequence * (-1);
            }
            Console.WriteLine(count);
        }

    }
}

