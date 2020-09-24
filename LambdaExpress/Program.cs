using System;
using System.Linq;

namespace LambdaExpress
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
