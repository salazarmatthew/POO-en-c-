using System;

namespace EmployeeManagementApp
{
    class Program
    {
        static void Main()
        {
            // Create an instance of Employee
            Employee employee = new Employee("John Doe", 50000);

        // Crear una instancia de Manager
        Manager manager = new Manager("Jane Smith", 70000, "Sales");

            // Display information using the IMostrarInformacion interface
            DisplayInformation(employee);
            DisplayInformation(manager);
        }

        static void DisplayInformation(IMostrarInformacion obj)
        {
            obj.ShowInformation();
        }
    }
}