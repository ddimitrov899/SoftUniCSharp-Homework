using System;
using System.Linq;

class Fibonacci_Numbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int countFibonacci = Fib(num);
        Console.WriteLine(countFibonacci);
    }
 
    static int Fib(int n)
    {
        int countFibonacci = 1;
        int previousFionacciNum = 0;
        int nextFibonacciNum = 1;

        for (int i = 0; i < n; i++)
        {
            countFibonacci = previousFionacciNum + nextFibonacciNum;
            previousFionacciNum = nextFibonacciNum;
            nextFibonacciNum = countFibonacci;
        }
        return countFibonacci;
    }
}

