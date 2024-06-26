using System;

namespace Practice_Mat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert matrix order: ");
            int order = int.Parse(Console.ReadLine());
            int[,] mat = new int[order, order];
            int i, j;
            int negative = 0;
            for (i = 0; i < order; i++)
            {
                for (j = 0; j < order; j++)
                {
                    Console.Write("Insert the number at position [" + i + "][" + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMain diagonal: ");
            for (i = 0; i < order; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            for (i = 0; i < order; i++)
            {
                for (j = 0; j < order; j++)
                {
                    if (mat[i, j] < 0) negative++;
                }
            }
            Console.WriteLine("\nNegative numbers =  " + negative);

            Console.WriteLine("\n---Matrix---");
            for (i = 0; i < order; i++)
            {
                for (j = 0; j < order; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}