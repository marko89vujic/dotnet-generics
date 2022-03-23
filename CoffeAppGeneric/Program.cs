﻿
using System;
using CoffeeAppGeneric.Data;
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
            Console.WriteLine("=============================================");
            Console.ReadLine();
        }

        private static void PrintOrganizationAndEmployees()
        {
            var employees = new SQLRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employees);

            GetByIdExample(employees);

            employees.Save();
            WriteAllEmployees(employees);
            var organizations = new SQLRepository<Organization>(new StorageAppDbContext());
            AddOrganizations(organizations);

            organizations.Save();
        }

        private static void WriteAllEmployees(SQLRepository<Employee> employees)
        {
            var items = employees.GetAll();

            foreach (var item in items)
            {
                Console.WriteLine($"Item: Id: {item.Id}, Name: {item.Name}");
            }
        }

        private static void GetByIdExample(ISqlRepository<Employee> _items)
        {
            var employee = _items.GetById(1);

            Console.WriteLine($"Employee with id 1: {employee.Name}");
        }

        private static void AddOrganizations(ISqlRepository<Organization> organizations)
        {
            organizations.Add(new Organization { Name = "enjoy.ing" });
            organizations.Add(new Organization {  Name = "ATT" });
        }

        private static void AddEmployees(ISqlRepository<Employee> employees)
        {
            employees.Add(new Employee {  Name = "Marko" });
            employees.Add(new Employee {  Name = "Katarina" });
            employees.Add(new Employee {  Name = "Sofija" });
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
