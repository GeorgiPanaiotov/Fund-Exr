using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixPrint(int.Parse(Console.ReadLine()));
        }

        static void MatrixPrint(int n)
        {
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = n;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
