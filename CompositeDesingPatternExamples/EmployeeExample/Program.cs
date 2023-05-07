using System;

namespace CompanyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = CreateCompany();

            manager.GetEmployeeDetails();

            Console.ReadKey();
        }

        private static IEmployee CreateCompany()
        {
            var manager1 = new Manager()
            {
                Id = 1,
                FirstName = "A",
                LastName = "B",
                PhoneNumber = "1",
                Salary = 100000.00,
                Title = "CEO"
            };
            var manager2 = new Manager()
            {
                Id = 2,
                FirstName = "C",
                LastName = "D",
                PhoneNumber = "2",
                Salary = 75000.00,
                Title = "CTO"
            };

            var developer1 = new Developer()
            {
                Id = 1,
                FirstName = "E",
                LastName = "F",
                PhoneNumber = "3",
                Salary = 50000.00,
                Title = "Backend Developer"
            };
            var developer2 = new Developer()
            {
                Id = 2,
                FirstName = "G",
                LastName = "H",
                PhoneNumber = "4",
                Salary = 50000.00,
                Title = "Frontend Developer"
            };

            manager1.AddEmployee(manager2);

            manager2.AddEmployee(developer1);
            manager2.AddEmployee(developer2);

            return manager1;
        }
    }
}
