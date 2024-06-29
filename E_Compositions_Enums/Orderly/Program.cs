using System;
using System.Globalization;
using Orderly.Entities;
using Orderly.Entities.Enums;


namespace Orderly
{
    internal class Ordely
    {
        static void Main(string[] args)
        {
            string email, name, status;
            int qnt, quantity, i;
            double price;
            DateTime data;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth date (dd/mm/yyyy): ");
            data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(name, email, data);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            status = Console.ReadLine();
            Console.Write("How many items in this order? ");
            qnt = int.Parse(Console.ReadLine());

            Order order = new Order(Enum.Parse<OrderStatus>(status), client);

            for (i = 0; i < qnt; i++)
            {
                Console.WriteLine($"\nEnter #{i + 1} item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("quantity: ");
                quantity = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(quantity, new Product(name, price)));
            }

            Console.WriteLine("\n" + order.ToString());
        }
    }
}