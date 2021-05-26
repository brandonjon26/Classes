using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees = new List<Employee>();

        public void EmployeeList(string Info)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine(Info);
            }
        }

        public Company(string CompanyName, DateTime Date)
        {
            Name = CompanyName;
            CreatedOn = Date;
        }

        public void HireEmployee(Employee Person)
        {
            Employees.Add(Person);
        }

        public void NewEmployeeList()
        {
            foreach (Employee item in Employees)
            {
                Console.WriteLine($"{item.firstName} {item.lastName} works for for this company as {item.title} since {item.startDate.ToShortDateString()}.");
            }
        }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}