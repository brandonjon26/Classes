using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime alpha = new DateTime(2021, 05, 26);

            // Create an instance of a company. Name it whatever you like.
            Company ThisCompany = new Company("MyStartup", alpha);

            // Create three employees
            ThisCompany.HireEmployee(new Employee("Brandon", "Hill", "Owner", new DateTime(2021, 05, 26)));
            ThisCompany.HireEmployee(new Employee("Stone", "Cold", "Boss Man", new DateTime(2021, 05, 27)));
            ThisCompany.HireEmployee(new Employee("Dick", "Richard", "New Hire", new DateTime(2021, 05, 28)));
            ThisCompany.NewEmployeeList();

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}