﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 123, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 456, FirstName = "Mark", LastName = "Smith" },
                new Employee { Id = 789, FirstName = "Jason", LastName = "Bark" },
                new Employee { Id = 012, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 345, FirstName = "Meg", LastName = "Atron" },
                new Employee { Id = 678, FirstName = "Mel", LastName = "Cooke" },
                new Employee { Id = 901, FirstName = "Lay", LastName = "Crisp" },
                new Employee { Id = 234, FirstName = "Joe", LastName = "Mail" },
                new Employee { Id = 567, FirstName = "Bre", LastName = "Che" },
                new Employee { Id = 890, FirstName = "Marge", LastName = "Leg" }
            };

            //Use foreach loop
            List<Employee> joeList = new List<Employee>();
            int counter = 0;
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                    counter++;
                }

            }
            Console.WriteLine(joeList.Count());
            Console.ReadLine(); //output should be 2


            //try a lambda function "for each employee x in the list, where firstname equals joe
            int count = employees.Count(x => x.FirstName == "Joe");
            Console.WriteLine(count);
            Console.ReadLine();

            



        }
    }
}

