using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        string[] nameSplit = name.Split(' ');

        string removeName = Console.ReadLine();
        string[] removeNameSplit = removeName.Split(' ');

        List<string> nameList = new List<string>();
        for (int i = 0; i < nameSplit.Length; i++)
        {
            nameList.Add(nameSplit[i]);
        }
        for (int i = 0; i < removeNameSplit.Length; i++)
        {
            nameList.Remove(removeNameSplit[i]);
        }
        foreach (var names in nameList)
        {
            Console.Write(names+" ");
        }
        Console.WriteLine();
    }
}

