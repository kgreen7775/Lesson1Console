using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //field
        private Double _salary { get; set; }

        public void setSalary(double salary)
        {
            _salary = salary;
        }
        public double getSalary()
        {
            return _salary;
        }

        internal void setSalary(object salary)
        {
            throw new NotImplementedException();
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";

        }

        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";

        }


    }
}