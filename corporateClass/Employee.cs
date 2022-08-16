using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporateClass
{
    internal class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public void ShowEmployee()
        {
            Console.WriteLine($@"Employee: {FirstName} {LastName}
Title: {Title}
Hire Date: {StartDate}");
        }
    }
}
