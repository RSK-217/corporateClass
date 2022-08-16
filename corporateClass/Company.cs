using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace corporateClass
{
    internal class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<string> _currentEmployees;

        // Create a method that allows a caller to add an employee
        //public void NewEmployee(string employee)
        //{
        //    _currentEmployees.Add(employee);
        //}

        // Create a method that allows a caller to remove an employee
        //public void Exemployee(string ex)
        //{
        //    _currentEmployees.Remove(ex);    
        //}
        // Create a method that allows a caller to retrieve the list of employees
        public void GetCompanies()
        {
            Console.WriteLine($"{Name} was founded on {CreatedOn}");
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
        }
    }
}
