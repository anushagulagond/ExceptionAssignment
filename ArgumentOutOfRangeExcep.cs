using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class ArgumentOutOfRangeExcep
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string MyString=Console.ReadLine();
            try
            {
                Console.WriteLine("Enter start Index and end Index to get substring ");
                Console.WriteLine("Enter starting Index");
                int Index1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end Index");
                int Index2 = int.Parse(Console.ReadLine());
                Console.WriteLine(MyString.Substring(Index1, Index2));
            }catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
