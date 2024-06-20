using System;

namespace Code4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, c = -7;
            int delta = (int)Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("{0}x^2 +{1}x {2} = 0\n\nx1={3:2}\tx2={4:2}", a,b,c,x1,x2);

        }
    }
}