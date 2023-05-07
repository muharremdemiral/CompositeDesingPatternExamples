using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExample
{
    public interface IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        
        public void GetEmployeeDetails(string indentation = "");
    }
}
