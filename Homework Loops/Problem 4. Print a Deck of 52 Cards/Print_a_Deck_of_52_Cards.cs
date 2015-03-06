using System;

class Print_a_Deck_of_52_Cards
{
    static void Main()
    {
        int dekc = 0;
        while (true)
        {
            // sorting cards
            for (int cards = 2; cards < 15; cards++)
            {
                // sorting symbols
                for (char  symbols = (char)3;  symbols < 7;  symbols++)
                {
                    if (cards < 11)
                    {
                        // print cards 2 to 10
                        Console.Write(cards + "" +  symbols);
                    }
                    else
                    {
                        // print cards J to A
                        switch (cards)
                        {

                            case 11:
                                Console.Write("J" + "" +  symbols);
                                break;
                            case 12:
                                Console.Write("Q" + "" +  symbols);
                                break;
                            case 13:
                                Console.Write("K" + "" +  symbols);
                                break;
                            default:
                                Console.Write("A" + "" +  symbols);
                                break;
                        }
                    }


                    dekc++;
                    if (dekc == 52)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
