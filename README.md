# Employee Management App

This is a simple C# console application for managing employees. It demonstrates the use of classes, inheritance, interfaces, and polymorphism.

## Files

- `src/Program.cs`: This is the main entry point of the application. It creates instances of the `Employee` and `Manager` classes and uses the `IMostrarInformacion` interface to display their information.

- `src/Employee.cs`: This file defines the `Employee` class. The class has two public properties: `Name` of type string and `Salary` of type double. It also has a method `CalculateAnnualSalary` that returns the annual salary of the employee.

- `src/Manager.cs`: This file defines the `Manager` class that inherits from the `Employee` class. In addition to the properties inherited from `Employee`, it has an additional property `Department` of type string that represents the department the manager supervises.

- `src/IMostrarInformacion.cs`: This file defines the `IMostrarInformacion` interface. The interface has a method `ShowInformation` that classes implementing the interface must define.

- `EmployeeManagementApp.csproj`: This is the project file which contains information about the project and its dependencies.

## How to Use

1. Open the project in your preferred C# IDE.
2. Run the `Program.cs` file to start the application.
3. The application will create instances of `Employee` and `Manager` and display their information.

## Dependencies

This project does not have any dependencies.