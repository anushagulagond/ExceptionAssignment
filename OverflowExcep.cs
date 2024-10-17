using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class OverflowExcep
    {
        public static void Main(string[] args)
        {
            int num;
            try
            {
                Console.WriteLine("Enter integer value which need to throw overflow exception");
                num = int.Parse(Console.ReadLine());
            }catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
