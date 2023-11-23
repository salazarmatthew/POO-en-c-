using System;

namespace EmployeeManagementApp
{
    public class Manager : Employee, IMostrarInformacion
    {
        public string Department { get; set; }

        public Manager(string name, double salary, string department) : base(name, salary)
        {
            Department = department;
        }

       
        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}, Department: {Department}");
        }
    }
}