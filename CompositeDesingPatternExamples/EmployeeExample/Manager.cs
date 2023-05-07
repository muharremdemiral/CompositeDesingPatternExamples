using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExample
{
    public class Manager : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }

        private List<IEmployee> _employees = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public void GetEmployeeDetails(string indentation = "")
        {
            Console.WriteLine($"{indentation}{Title}"); 

            if (_employees.Count <= 0) return;

            foreach (var employee in _employees)
            {
                employee.GetEmployeeDetails("  ");
            }
        }
    }
}
