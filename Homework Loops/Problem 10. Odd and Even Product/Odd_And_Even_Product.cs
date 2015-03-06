using System;

class Odd_And_Even_Product
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
        int productOfEven = 1;
        int productOfOdd = 1;
        for (int i = 0; i < n.Length; i++)
        {
            int newNmasive = int.Parse(n[i]);
            if (i % 2 == 0) 
            {
                productOfEven *= newNmasive;
            }
            else
            {
                productOfOdd *= newNmasive;
            }
        }
        if (productOfEven == productOfOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",productOfOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",productOfOdd);
                Console.WriteLine("even_product = {0}",productOfEven);
            }
    }
}

