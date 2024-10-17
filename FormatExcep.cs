using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class FormatExcep
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Something that you need to convert into int");
                int Val = int.Parse(Console.ReadLine());
                Console.WriteLine("value: " + Val);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
