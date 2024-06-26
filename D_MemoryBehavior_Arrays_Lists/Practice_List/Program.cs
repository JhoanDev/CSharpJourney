using System;
using System.Globalization;
namespace Practice_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int num;
            int id;
            string str;
            double numdecimal;
            Console.Write("How many employees will be registered? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1));
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                str = Console.ReadLine();
                Console.Write("Salary: ");
                numdecimal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, str, numdecimal));

            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            Employee aux = employees.Find(x => x.Id == id);

            if (aux != null){
                Console.Write("Enter the percentage: ");
                numdecimal = double.Parse(Console.ReadLine());
                aux.IncreaseSalary(numdecimal);
            }
            else Console.WriteLine("This id does not exist!");

            Console.WriteLine("\nUpdated list of employees: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}