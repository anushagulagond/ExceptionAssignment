using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class NestedTryCatch
    {
        public static void Main(string[] args)
        {
            try
            {
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
            catch (FormatException ex)
            {
                Console.WriteLine("Given input is not in Integer format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
