using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orderly.Entities.Enums;

namespace Orderly.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; }

        public Client Clint { get; set; }

        public Order(OrderStatus status, Client clint)
        {
            Moment = DateTime.Now;
            Status = status;
            Items = new List<OrderItem>();
            Clint = clint;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("ORDER SUMMARY: ");
            s.AppendLine("Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            s.AppendLine("Status: " + Status.ToString());
            s.AppendLine("Client: " + Clint.Name + " (" + Clint.BirthDate.ToString("dd/MM/yyyy") + ") - " + Clint.Email);
            s.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                s.AppendLine(item.ToString());
            }
            s.AppendLine("Total price: " + this.Total().ToString("C"));
            return s.ToString();
        }
    }
}
