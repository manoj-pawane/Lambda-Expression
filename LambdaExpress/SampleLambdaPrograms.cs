using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpress
{
    public class SampleLambdaPrograms
    {
        public void ExampleOne()
        {
            /// Expression Lambda Example 1
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            /// Expression Lambda Example 2
            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);

            ///Lambda with LINQ Example
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));


            ///Statement Lambda
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");

            ///  Return Value   
            Func<int, int> multiplyByFive = num =>
            {
                int product = num * 5;
                return product;
            };

            int result = multiplyByFive(7);
        }

        public void ExampleTwo()
        {
            // List to store numbers 
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

            // foreach loop to dislay the list 
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression 
            // to calculate square of 
            // each value in the list 
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares 
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda exression to 
            // find all numbers in the list 
            // divisible by 3 
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            // foreach loop to display divBy3 
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }

        public void ExampleThree()
        {
            List<Developer> developers = new List<Developer>()
            {
                new Developer{name="Sam", technology="Java"},
                new Developer{name="Mike", technology="node js"},
                new Developer{name="Steven", technology=".Net core"}
            };

            // To sort the developers list  
            // based on name of student 
            // in acsending order
            var developerDetails = developers.OrderBy(x => x.name);
            foreach(var value in developerDetails)
            {
                Console.WriteLine(value.name+" "+value.technology);
            }
        }
    }

    public class Developer
    {
        public string name { get; set; }
        public string technology { get; set; }
    }
}
