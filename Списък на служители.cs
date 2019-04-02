using System;
using System.Linq;
using System.Collections.Generic;

namespace Employee.List
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();
            Dictionary<string, List<double>> DepartmenSalaries = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputLine = Console.ReadLine().Split(' ').ToList();
                string name = inputLine[0];
                double salary = double.Parse(inputLine[1]);
                string position = inputLine[2];
                string department = inputLine[3];
                string email = "n/a";
                int age = -1;
                if (inputLine.Count == 5)
                {
                    if (inputLine[4].Contains('@'))
                    {
                        email = inputLine[4];
                    }
                    else
                    {
                        age = int.Parse(inputLine[4]);
                    }
                }
                else if (inputLine.Count == 6)
                {
                    email = inputLine[4];
                    age = int.Parse(inputLine[5]);
                }

                employeeList.Add(new Employee(name, salary, position, department, email, age));
                if (DepartmenSalaries.ContainsKey(department))
                {
                    DepartmenSalaries[department].Add(salary);
                }
                else
                {
                    /* List<double> newList = new List<double>();
                     newList.Add(salary);
                     DepartmenSalaries.Add(department, newList);
                     // DepartmenSalaries[department].Add(salary); */
                    DepartmenSalaries.Add(department, new List<double>() { salary });
                }

            }
            //  List<Employee> sortedEmployeeList = employeeList.OrderBy(element => element.Salary).ToList();
          //  DepartmenSalaries.OrderByDescending(element => element.Value.Average());
            
            string DepartmentHighSalary = DepartmenSalaries.OrderByDescending(element => element.Value.Average()).First().Key;
            Console.WriteLine("Highest Average Salary: {0}", DepartmentHighSalary);
            foreach (var item in employeeList.OrderByDescending(element => element.Salary))
            {
                if (item.Department == DepartmentHighSalary)
                {
                    Console.WriteLine(item.ToString());
                }
            }



        }
    }
}
