using System;

namespace _03.Company_Hierarchy
{
    using Enums;
    using People;
    using Projects;

    class CompanyHierarchyMain
    {
        static void Main()
        {
            SalesEmployee retailer = new SalesEmployee(12, "Firstname", "Lastname", Department.Marketing, 500, new Sale("notebook", 340));

            Employee[] employees = 
            {
                retailer,
                new Manager(28882, "Shef", "Shefov", Department.Marketing, 5500, retailer),
                new Developer(534, "Katya", "Katerina", Department.Production, 2300, new Project("Code")),
                new SalesEmployee(342, "Ivan", "Ivanov", Department.Accounting, 1200, new Sale("Neshto", 0)), 
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
