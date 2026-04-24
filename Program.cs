using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Emmanuel Holmes - Week 3 Employee Management Project");
        Console.WriteLine("Welcome to the Employee Management Application");
        Console.WriteLine("This program demonstrates abstraction, constructors, and access specifiers.\n");

        Department hr = new Department("Human Resources", "Linda Brown");
        Department it = new Department("Information Technology", "Marcus Green");
        Department sales = new Department("Sales", "Angela White");

        List<Employee> employees = new List<Employee>();

        employees.Add(new FullTimeEmployee(101, "John Smith", "HR Manager", hr, 60000));
        employees.Add(new PartTimeEmployee(102, "Jane Jones", "Help Desk Tech", it, 22.50, 80));
        employees.Add(new ContractEmployee(103, "Mike Davis", "Sales Consultant", sales, 12000, 6));

        Console.WriteLine("Employee Information\n");

        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i]);
            Console.WriteLine("------------------------------");
        }

        Console.WriteLine("\nProgram complete.");
    }
}