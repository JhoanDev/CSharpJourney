using Practice1.Entities;
using Practice1.Entities.Enums;
using System;
using System.Globalization;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string department, name, data, monthYear;
            double baseSalary, valueHour;
            int quantityContracts, hours, month, year, i;
            DateTime dataContract;
            WorkerLevel level;


            Console.Write("Enter department´s name: ");
            department = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, new Departament(department));

            Console.Write("\nHow many contracts to this worker? ");
            quantityContracts = int.Parse(Console.ReadLine());

            for (i = 0; i < quantityContracts; i++)
            {
                Console.WriteLine("\nEnter #{0} contract data: ", i + 1);
                Console.Write("Date (DD/MM/YYYY): ");
                dataContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(dataContract, valueHour, hours));

            }
            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            monthYear = Console.ReadLine();
            month = int.Parse(monthYear.Substring(0, 2));
            year = int.Parse(monthYear.Substring(3));

            Console.WriteLine("\nName: " + worker.name);
            Console.WriteLine("Department: " + worker.Dept.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month).ToString("C"));

        }
    }
}