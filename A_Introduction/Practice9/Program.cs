using System;

namespace Practice9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            do
            {
                entrada = int.Parse(Console.ReadLine());
                switch (entrada)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        break;
                }
            } while (entrada != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}