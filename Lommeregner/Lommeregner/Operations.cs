using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner
{
    internal static class Operations
    {
        internal static decimal Addition()
        {
            Console.WriteLine("First number");
            var a = GetNumber();
            Console.WriteLine("Second number");
            var b = GetNumber();

            return a+b;
        }

        internal static decimal Substraction()
        {
            Console.WriteLine("First number");
            var a = GetNumber();
            Console.WriteLine("Second number");
            var b = GetNumber();

            return a - b;
        }

        internal static decimal Multiplication()
        {
            Console.WriteLine("First number");
            var a = GetNumber();
            Console.WriteLine("Second number");
            var b = GetNumber();

            return a * b;
        }


        internal static decimal Division()
        {
            Console.WriteLine("First number");
            var a = GetNumber();
            Console.WriteLine("Second number");
            
            DivisionByZeroClause:
            var b = GetNumber();
            if (b == 0)
            {
                Console.WriteLine("cannot divide by 0. Try a different number");
                goto DivisionByZeroClause;
            }

            return a / b;
        }

        internal static decimal GetNumber()
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                // 'result' is now safe to use for calculations
                Console.WriteLine($"Success: {result}");
                return result;
            }
            else
            {
                // The input was invalid (e.g., "abc")
                Console.WriteLine("Error: Please enter a valid number.");
                return GetNumber();
            }

        }

        internal static double Sqrt()
        {
            SquareRootClause:
            Console.WriteLine("Square root number");
            var a = GetNumber();
            if (a < 0)
            {
                Console.WriteLine("cannot square root negative numbers. Try a positive number");
                goto SquareRootClause;
            }

            return Math.Sqrt((double)a);
        }

        internal static double Pow()
        {
            Console.WriteLine("First number");
            var a = GetNumber();
            Console.WriteLine("Second number");
            var b = GetNumber();

            return Math.Pow((double)a, (double)b);
        }
    }
}
