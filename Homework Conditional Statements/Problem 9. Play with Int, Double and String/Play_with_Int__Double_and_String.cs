using System;

class Play_with_Int__Double_and_String
{
    static void Main()
    {
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int typeInt = int.Parse(Console.ReadLine());
                Console.WriteLine(typeInt + 1);
                return;
            case 2:
                Console.Write("Please enter a double: ");
                double typeDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(typeDouble + 1);
                return;
            case 3:
                Console.Write("Please enter a string: ");
                string typeString = Console.ReadLine();
                Console.WriteLine(typeString + "*");
                return;
        }
    }
}
