using Practice_Array;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room[] vet = new Room[10];
            int quantity = 0;
            Console.Write("How many rooms will be rented? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("\nRent #" + (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Number room: ");
                int room = int.Parse(Console.ReadLine());

                while (vet[room] != null)
                {
                    Console.WriteLine("Room is occupied. Unable to rent.");
                    Console.Write("Please enter a new room number: ");
                    room = int.Parse(Console.ReadLine());
                }

                vet[room] = new Room(name, email);
            }

            Console.WriteLine("\nBusy rooms");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}