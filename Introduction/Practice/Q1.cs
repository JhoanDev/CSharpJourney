using System;


namespace Practice
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = " + (horas * valorHora).ToString("C"));

        }
    }
}
