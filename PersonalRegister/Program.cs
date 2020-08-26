using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
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

            do
            {
                PrintMeny();
            } while (true);
        }

        private static void PrintMeny()
        {
            Console.WriteLine("1. Add new Employee");
            Console.WriteLine("2. Print");
            Console.WriteLine("Q. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Print();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void Print()
        {
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);

                //if (employee.SalaryLevel.Equals(SalaryLevel.Junior))
                //{
                //    Console.WriteLine(DoJuniorWork());
                //}
                //if (employee.SalaryLevel.Equals(SalaryLevel.Senior))
                //{
                //    Console.WriteLine(DoSeniorWork());
                //}

                Console.WriteLine(employee.SalaryLevel.Equals(SalaryLevel.Junior) ? 
                    DoJuniorWork() : 
                    DoSeniorWork());
            }
        }

        private static string DoSeniorWork()
        {
            return "Do senior work";
        }

        private static string DoJuniorWork()
        {
            return "Do junior work";
        }

        private static void Add()
        {
            Console.WriteLine("Add a new Employee, Quit with Q");

            do
            {

                string name = Util.AskForString("Name: ");
                if (name == "Q") break;
                int salary = Util.AskForInt("Salary");
                payroll.AddEmployee(name, salary);

            } while (true);
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