using System;

class Program
{


    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] arrSort = MethodArr(num);
        foreach (var sortArr in arrSort)
        {
            Console.WriteLine(sortArr);
        }
    }

    static int[] MethodArr(int inputCount)
    {
        int[] array = new int[inputCount];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        return array;
    }
}