using System;
using System.Collections.Generic;
namespace CompanyPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Company NashvilleSoftWareSchool = new Company("NashvilleSoftWareSchool", DateTime.Now);

            Employee firstEmployee = new Employee()
            {
                FirstName = "Frank ",
                LastName = "Smith",
                Title = "Toilet Scrubber",
                StartDate = new DateTime(2015, 3, 2)
            };
            Employee SecondEmployee = new Employee()
            {
                FirstName = "BOB ",
                LastName = "Smith",
                Title = "Master Toilet Scrubber",
                StartDate = new DateTime(2015, 3, 2)
            };
            Employee ThirdEmployee = new Employee()
            {
                FirstName = "Jill ",
                LastName = "Smith",
                Title = "Apprentice Toilet Scrubber",
                StartDate = new DateTime(2015, 3, 2)
            };
            Employee FourthEmployee = new Employee()
            {
                FirstName = "Jim ",
                LastName = "Smith",
                Title = "Pickker upper",
                StartDate = new DateTime(2015, 3, 2)
            };
            // Assign the employees to the company
            NashvilleSoftWareSchool.AddEmployee(firstEmployee);
            NashvilleSoftWareSchool.AddEmployee(SecondEmployee);
            NashvilleSoftWareSchool.AddEmployee(ThirdEmployee);
            NashvilleSoftWareSchool.AddEmployee(FourthEmployee);
            NashvilleSoftWareSchool.ListEmployee();
        }
    }
}

