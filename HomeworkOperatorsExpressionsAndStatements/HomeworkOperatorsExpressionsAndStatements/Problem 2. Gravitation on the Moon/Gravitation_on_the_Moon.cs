using System;

class Gravitation_on_the_Moon
{
    static void Main()
    {
        // The gravitational field of the Moon is approximately 17% of that on the Earth. 
        //Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
        double earthGravity = double.Parse(Console.ReadLine());
        double moonGravity = earthGravity * 0.17;
        Console.WriteLine(moonGravity);
    }
}
