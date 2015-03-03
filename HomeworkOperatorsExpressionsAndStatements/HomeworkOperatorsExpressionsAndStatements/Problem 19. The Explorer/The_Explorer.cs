using System;

class The_Explorer
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        // all in a 3 method
        char asterix = '*';
        char dash = '-';
        int halfN = n / 2;
        char[,] matrix = new char[n, n];

        // drawing a matrix
        fillMatrix(n, dash, matrix);

        int topRow = 0;
        int bottRow = n - 1;
        int leftPivot = n / 2;
        int rightPivot = n / 2 + 1;
        
        // the actual filling of the matrix
        
        theExplorer(asterix, halfN, matrix, ref topRow, ref bottRow, ref leftPivot, ref rightPivot);


        //print matrix

        printMatrix(n, matrix);

    }

    private static void theExplorer(char asterix, int halfN, char[,] matrix, ref int topRow, ref int bottRow, ref int leftPivot, ref int rightPivot)
    {
        for (int i = leftPivot - 1; i < leftPivot; i++)
        {
            matrix[topRow, leftPivot] = asterix;
            matrix[bottRow, leftPivot] = asterix;
        }
        leftPivot--;
        topRow++;
        bottRow--;
        for (int i = 0; i < halfN; i++)
        {
            matrix[topRow, leftPivot] = asterix;
            matrix[bottRow, leftPivot] = asterix;

            matrix[topRow, rightPivot] = asterix;
            matrix[bottRow, rightPivot] = asterix;
            leftPivot--;
            rightPivot++;
            topRow++;
            bottRow--;
        }
    }

    private static void printMatrix(int n, char[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void fillMatrix(int n, char dash, char[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = dash;
            }
        }
    }
}


