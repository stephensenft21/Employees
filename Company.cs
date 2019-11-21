using System;
using System.Collections.Generic;
namespace CompanyPractice
{
    public class Company
    {
        //CONSTRUCTOR
        /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;

        }

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        List<Employee> EmployeeList = new List<Employee>();
        public void AddEmployee(Employee emp) => EmployeeList.Add(emp);

        public void ListEmployee()
        {
            foreach (Employee item in EmployeeList)
            {

                Console.WriteLine($"{item.FirstName}{item.LastName} works for {this.Name} as {item.Title} since {item.StartDate.ToShortDateString()}");

            }

        }

    }

}