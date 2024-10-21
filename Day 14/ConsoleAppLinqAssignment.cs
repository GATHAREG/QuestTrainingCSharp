/*1. Filter Even Numbers
Given a list of integers, return all the even numbers.

2. Filter Strings Starting with 'A'
From a list of strings, return those that start with the letter 'A'.

3. Sort in Descending Order
Sort a list of integers in descending order.

4. Square of Each Number
From a list of integers, return the square of each integer.

5. Square of Even Numbers
From a list of integers, return the squares of only the even numbers.

6. Find First String Starting with 'B'
From a list of strings, return the first string that starts with the letter 'B'. If none exists, return null.

7. Students Scoring Above 80
Given two lists, one containing students' names and the other their grades, return the names of students who scored more than 80.

8. Group Words by Length
Group a list of words by their length.

9. Find Maximum Value
From a list of integers, return the maximum value.

10. Find Minimum Value
From a list of integers, return the minimum value.

11. Check for Numbers Greater Than 50
From a list of integers, check if any number is greater than 50.

12. Check if All Numbers Are Positive
From a list of integers, check if all numbers are positive.


13. Sum of All Elements
Return the sum of all elements in a list of integers.

14. Calculate Average
Return the average of a list of floating-point numbers.

15. Remove Duplicates
From a list of integers with duplicates, return only the distinct numbers.

16. Count Elements Greater Than 10
From a list of integers, count how many elements are greater than 10.

17. Join Employees with Departments
Given two lists, one of employees and one of departments, return a list of employees with their corresponding department names based on department IDs.

18. Filter and Sort Products by Price
From a list of products, return those with prices greater than $100, sorted in ascending order.

19. Skip and Take Elements
From a list of integers, skip the first 5 elements and return the next 3 elements.

20. Zip Two Lists Together
Given two lists of the same length, combine corresponding elements into pairs.*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinq
{
    class Product
    {
        public string Name { get; set; }
        public  int Price { get; set; }

    }
    class Employee
    {
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int> { 1, 2, 3, 4, 12, 13, 14, 15, 16, 17, 18, 20, 22, 1, 2, 4 };

            //1. filter even numbers
            var res = lst.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", res));

            //2.string starting with 'a'
            var names = new List<string> { "Anil", "Mohan", "Neelima", "Mridula", "Bill", "Bony" };
            var namesStartWithA = names.Where(s => s.StartsWith("A"));
            Console.WriteLine(string.Join(",",namesStartWithA));


            //3.sort in descending
            var sortDescend = lst.OrderByDescending(x => x);
            Console.WriteLine(string.Join(",",sortDescend));


            //4.square of each number
            var square = lst.Select(x => x * x);
            Console.WriteLine(string.Join(",",square));


            //5.square of even only 
            var squareEven = res.Select(x => x * x);
            Console.WriteLine(string.Join(",",squareEven));


            //6.string starts with b
            var namesWithB = names.Where(s => s.StartsWith("B")).FirstOrDefault();
            Console.WriteLine(string.Join(",",namesWithB));


            //8.group words by length
            var groupby = names.GroupBy(x => x.Length);
            foreach (var group in groupby)
            {
                Console.WriteLine($"Names of  length {group.Key}:");

                foreach (var name in group)
                {
                    Console.WriteLine($"\t{name}");
                }
            }
            //9.max value
            var max = lst.Max();
            Console.WriteLine(max);
            //10.min
            var min = lst.Min();
            Console.WriteLine(min);

            // 11.check if number is  greater than 50
            //var checkOne = lst.Where(x => x > 50);
            var check = lst.Any(x => x > 50);
            Console.WriteLine(check);

            // 12.checking if all numbers positive

            var checkPositive = lst.All(x => x > 0);
            Console.WriteLine(checkPositive);

            // 13.sum of all elements
            var sum = lst.Sum();
            Console.WriteLine(sum);

            // 14.calculate average
            var numbers = new List<double> { 12.0, 17.8, 13.67, 10.0, 2.4, 3.14 };
            var average = numbers.Average();
            Console.WriteLine(average);

            // 15.remove duplicate and return distinct

            var distinct = lst.Distinct();
            Console.WriteLine(string.Join(",",distinct));

            // 16.count of numbers greater than 10
            var countGreaterTen = lst.Count(x => x > 10);
            Console.WriteLine(countGreaterTen);


            //19. skip first 5 and take the next 3
            var skipAndTake = lst.Skip(5).Take(3);
            Console.WriteLine(string.Join(",",skipAndTake));


            //20.zip
            var listOfName = new List<string> { "Gatha", "Geethu", "Manu" };
            var listOfAge = new List<int> { 23, 25, 30 };
            var listsWithZip = listOfName.Zip(listOfAge,(name, age)=> new {Name = name ,Age = age});
            foreach(var item in listsWithZip)
            {
                Console.WriteLine($"{ item.Name} : { item.Age}");
            }

            Console.WriteLine();
            //7 .students scoring above 80

            //var student = new List<Students>
            //{

            //    new Students{Name = "Gatha", Grades = 90},
            //    new Students{Name = "Geethu", Grades = 100},
            //    new Students{Name = "Manu", Grades = 70},
            //    new Students{Name = "Midhun", Grades = 96}

            //};

            //var studentWithGrade = student.Where(s => s.Grades > 80);
            //foreach (var stud in studentWithGrade)
            //{
            //    Console.WriteLine(stud);
            //}
            var namess = new List<string>() { "S1", "S2", "S3", "S4", "S5" };
            var marks = new List<int>() { 80, 90, 85, 40, 50 };

            var ress = namess
                .Zip(marks, (namee, mark) => { return new { namee, mark }; })
                .Where(s => s.mark > 80)
                .Select(s => s.namee);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            // 17. Join Employees with Departments
            //Given two lists, one of employees and one of departments, return a list of employees with their corresponding department names based on department ID

            var employee = new List<Employee>
            {
                new Employee{Name = "Aleena", DeptId = 1},
                new Employee{Name = "Amritha", DeptId = 2},
                new Employee{Name = "Akshara", DeptId = 1}

            };
            var department = new List<Department>
            {
                new Department{DeptId = 1, DeptName = "Cs"},
                new Department{DeptId = 2, DeptName = "It"},
                
            };

            var employeeWithDeptName = employee.Zip(department, (empl, dept) => new { empl = empl.Name,dept = dept.DeptName });

            foreach(var detail in employeeWithDeptName)
            {
                Console.WriteLine($"{detail.empl}: {detail.dept}");
            }
            Console.WriteLine();

            var empWithDepts = employee
            .Join(
                 department,
                 e => e.DeptId,
                d => d.DeptId,
                (e, d) => new
                {
                    EmployeeName = e.Name,
                   DepartmentName = d.DeptName
                  }
              ); 

            foreach (var item in empWithDepts)
            {
                Console.WriteLine(item.EmployeeName + " - " + item.DepartmentName);
            }


            //18. Filter and Sort Products by Price
            //From a list of products, return those with prices greater than $100, sorted in ascending order.

            var productList = new List<Product>
            {
                new Product{ Name = "Colgate" , Price = 180},
                new Product{ Name = "Brush" , Price = 40},
                new Product{ Name = "Bottle" , Price = 130},
                new Product{ Name = "Calculator" , Price = 1000}

            };
            var productWithPriceGreater = productList.Where(p => p.Price > 100).OrderBy(p => p.Price).ToList();
            foreach(var product in productWithPriceGreater)
            {
                Console.WriteLine($"{product.Name} : {product.Price}");
            }




        }
    }
}
