using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        private char Gender { get; set; }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, char gender)
        {
            if (id <= 0)
                throw new ArgumentException("ID must be positive.");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");

            #region Part 3 Q3 - Need to restrict the Gender field to be only M or F
            if (gender != 'M' && gender != 'F')
                throw new ArgumentException("Gender must be 'M' or 'F'.");
            #endregion

            if (salary < 0)
                throw new ArgumentException("Salary cannot be negative.");

            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate ?? throw new ArgumentNullException(nameof(hireDate));
            Gender = gender;
        }

        #region Part 3 Q5 - Override ToString to display employee details in string format (with salary in currency format)
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
        #endregion

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1; 

            var thisHireDate = new DateTime(HireDate.Year, HireDate.Month, HireDate.Day);
            var otherHireDate = new DateTime(other.HireDate.Year, other.HireDate.Month, other.HireDate.Day);

            return thisHireDate.CompareTo(otherHireDate);
        }
    }


}



