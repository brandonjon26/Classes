using System;

namespace Classes
{
    public class Employee
    {
        public string firstName { get; }
        public string lastName { get; }
        public string title { get; }
        public DateTime startDate { get; }

        public Employee(string FName, string LName, string EmployeeTitle, DateTime Date)
        {
            firstName = FName;
            lastName = LName;
            title = EmployeeTitle;
            startDate = Date;
        }
    }
}