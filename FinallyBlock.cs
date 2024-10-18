using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class FinallyBlock
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a int value");
           
            try
            {
                int Value = int.Parse(Console.ReadLine());
                Console.WriteLine("Value is: " + Value);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am Finally block which executes all time");
            }
        }
    }
}
