namespace PersonalRegister
{
    public class Employee
    {
        //prop och om man vill ändra i koden så kör man propfull
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
            //constructor ser till så att saker händer
        {
            //this.name = Employee.name
            //this.name = Employee.salary
            Name = name;
            Salary = salary;
        }
    }
}