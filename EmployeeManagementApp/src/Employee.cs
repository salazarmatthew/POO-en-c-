using System;

namespace EmployeeManagementApp
{
    public class Employee : IMostrarInformacion
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}, Annual Salary: {CalculateAnnualSalary()}");
        }
    }
}