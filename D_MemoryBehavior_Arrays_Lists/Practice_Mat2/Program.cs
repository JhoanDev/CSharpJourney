using System;

namespace Practice_Mat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            entrada = Console.ReadLine().Split(' ');
            int row, column;
            row = int.Parse(entrada[0]);
            column = int.Parse(entrada[1]);

            int[,] mat = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++)
                {
                    mat[i, j] = int.Parse(entrada[j]);
                }
            }

            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mat[i, j] == target)
                    {
                        Console.WriteLine("\nPosition [" + i + ", " + j + "]");
                        if (j - 1 >= 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j + 1 < column) Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i - 1 >= 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (i + 1 < row) Console.WriteLine("Donw: " + mat[i + 1, j]);
                    }
                }
            }

        }
    }
}