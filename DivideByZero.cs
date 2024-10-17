using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class DivideByZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give two numbers as input");
            Console.WriteLine("Enter first number");
            int First = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int Second = int.Parse(Console.ReadLine());

            try
            {
                int Result = First / Second;
                Console.WriteLine("Result: " + Result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Denominator should not be zero");
            }
        }
    }
}
