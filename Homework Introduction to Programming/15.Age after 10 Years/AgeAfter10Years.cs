﻿using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        DateTime MyAge = DateTime.Parse(Console.ReadLine());
        long resulut = DateTime.Today.Subtract(MyAge).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
    }
}
