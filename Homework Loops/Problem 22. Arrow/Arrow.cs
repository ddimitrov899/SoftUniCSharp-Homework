using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsHight = n * 2 - 1;
        int dotsWidth = n * 2 - 1;
        
        char[,] matrix = Matrix(dotsHight, dotsWidth);
        // top
        int topRow = 0;
        int leftPivit = n / 2;
        for (int i = 0; i < n; i++, leftPivit++)
        {
            matrix[topRow, leftPivit] = '#';
        }
        // mid
        leftPivit = n / 2;
        int rightPivot = n / 2 + (n - 1);
        topRow++;
        for (int i = 0; i < n - 2 ; i++)
        {
            matrix[topRow, leftPivit] = '#';
            matrix[topRow, rightPivot] = '#';
            topRow++;
        }
        // bott
        for (int i = 0; i < n / 2 + 1; i++)
        {
            matrix[topRow, leftPivit] = '#';
            matrix[topRow, rightPivot] = '#';
            leftPivit--;
            rightPivot++;
        }
        leftPivit+=2;
        rightPivot-=2;
        topRow++;
        for (int i = 0; i < n - 1; i++)
        {
            matrix[topRow, leftPivit] = '#';
            matrix[topRow, rightPivot] = '#';
            leftPivit++;
            rightPivot--;
            topRow++;
        }
        fillTheMatrix(dotsHight, dotsWidth, matrix);
    }

    private static void fillTheMatrix(int dotsHight, int dotsWidth, char[,] matrix)
    {
        for (int row = 0; row < dotsHight; row++)
        {
            for (int col = 0; col < dotsWidth; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static char[,] Matrix(int dotsHight, int dotsWidth)
    {
        char[,] matrix = new char[dotsHight, dotsWidth];

        for (int row = 0; row < dotsHight; row++)
        {
            for (int col = 0; col < dotsWidth; col++)
            {
                matrix[row, col] = '.';
            }
        }
        return matrix;
    }
}

