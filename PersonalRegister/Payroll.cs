using System;
using System.Collections.Generic;

namespace PersonalRegister
{
    internal class Payroll
    {
        // skapa listan payroll
        private List<Employee> payroll;

        public Payroll()
        {
            // instatiate the list payroll
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }
        internal void AddEmployee(string name, int salary)
        {
            payroll.Add(new Employee(name, salary));
        }
    }
}