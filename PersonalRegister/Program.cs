using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace PersonalRegister
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            

            SeedData();

            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 10000);
            payroll.AddEmployee("Nisse", 15000);
            payroll.AddEmployee("Lisa", 17000);
            payroll.AddEmployee("Anne", 20000);
        }
    }
}