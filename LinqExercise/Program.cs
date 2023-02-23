using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of all numbers:");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of all number:");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();


            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Order by Ascending:");
            numbers.OrderBy(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();


            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Order by Decsending:");
            numbers.OrderByDescending(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6:");
            numbers.Where(num => num > 6).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Print Only 4 Numbers");
            

            foreach (var num in numbers.OrderBy(num => num).Take(4))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Change Index 4 to my Age, Then Organize in Descending Order:");
            numbers.SetValue(35, 4);
            numbers.OrderByDescending(num => num).ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();


            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a
            //C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Full Names That Start With C or S and Order in Acsending Order By First Name:");
            employees.Where(name => name.FirstName.StartsWith("C") || name.FirstName.StartsWith("S"))
                .OrderBy(name => name.FirstName)
                .ToList()
                .ForEach(name => Console.WriteLine(name.FullName));
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console
            //and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Full Name and Age of Those Over 26 Ordered by Age First Then First Name:");
            employees.Where(age => age.Age > 26)
                .OrderBy(age => age.Age)
                .ThenBy(name => name.FirstName)
                .ToList()
                .ForEach(name => Console.WriteLine($"Full Name: {name.FullName},    Age: {name.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of Years Of Experience:");
            var sumYoe = employees.Where(yoe => yoe.YearsOfExperience <= 10 && yoe.Age > 35)
                .ToList().Sum(yoe => yoe.YearsOfExperience);
            Console.WriteLine(sumYoe);
            Console.WriteLine();

            Console.WriteLine("Average of Years Of Experience:");
            var avgYoe = employees.Where(yoe => yoe.YearsOfExperience <= 10 && yoe.Age > 35)
                .ToList().Average(yoe => yoe.YearsOfExperience);
            Console.WriteLine(avgYoe);
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("Kenneth", "Baker", 35, 1)).ToList().ForEach(name => Console.WriteLine(name.FullName));
            
            

            Console.WriteLine();

            Console.ReadLine();
        }
         
        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10)); //no
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));//yes
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));//yes
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));//no
            employees.Add(new Employee("Jill", "Valentine", 32, 43));//no
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));//no
            employees.Add(new Employee("Big", "Boss", 23, 14));//no
            employees.Add(new Employee("Solid", "Snake", 18, 3));//no
            employees.Add(new Employee("Chris", "Redfield", 44, 7));//yes
            employees.Add(new Employee("Faye", "Valentine", 32, 10));//no

            return employees;
        }
        #endregion
    }
}
