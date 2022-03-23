
using System;
using CoffeeAppGeneric.Entities;
using CoffeeAppGeneric.Repositories;

namespace CoffeeAppGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            // First part of Tutorial (only implementation of Generic class SimpleStack<T>
            StackDoubles();
            StackStrings();
            Console.WriteLine("========================================");
            // Second part
            PrintOrganizationAndEmployees();
            Console.ReadLine();
        }

        private static void PrintOrganizationAndEmployees()
        {
            var employees = new GenericRepository<Employee,int>();
            employees.Add(new Employee { Id = 1, Name = "Marko"});
            employees.Add(new Employee { Id = 2, Name = "Katarina" });
            employees.Add(new Employee { Id = 3, Name = "Sofija" });

            employees.Save();

            var organizations = new GenericRepository<Organization, int>();
            organizations.Add(new Organization{Id=1, Name = "enjoy.ing"});
            organizations.Add(new Organization{Id = 2, Name = "ATT"});

            organizations.Save();
        }

        private static void StackDoubles()
        {
            var simpleStack = new SimpleStack<double>();
            simpleStack.Push(1.2);
            simpleStack.Push(4.6);
            simpleStack.Push(7.1);

            var sum = 0.0;

            while (simpleStack.Count > 0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"Items: {item}");
                sum += item;
            }

            Console.Write($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var simpleStack = new SimpleStack<string>();

            simpleStack.Push("marko");
            simpleStack.Push("katarina");
            simpleStack.Push("sofija");

            while (simpleStack.Count>0)
            {
                var item = simpleStack.Pop();
                Console.WriteLine($"{item}");
            }
        }
    }
}
