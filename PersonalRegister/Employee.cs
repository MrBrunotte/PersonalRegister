using System.Net.Http.Headers;

namespace PersonalRegister
{
    public class Employee
    {
        //prop och om man vill ändra i koden så kör man propfull
        public string Name { get; }
        public int Salary { get; }
        public SalaryLevel SalaryLevel 
        {
            get
            {
                if (Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            } 
        }

        public Employee(string name, int salary)
            //constructor ser till så att saker händer
        {
            //this.name = Employee.name
            //this.name = Employee.salary
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}