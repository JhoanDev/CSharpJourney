using Practice1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Entities
{
    internal class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double baseSalary { get; set; }
        public Departament Dept { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {
            Contracts = new List<HourContract>();
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament dept)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            Dept = dept;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double totalValue = baseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    totalValue += contract.TotalValue();
                }
            }
            return totalValue;
        }
    }
}
