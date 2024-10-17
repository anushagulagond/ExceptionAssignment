using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class NullReferenceExcept
    {
        public static void Main(string[] args)
        {
            string s=Console.ReadLine();
            try
            {
                s = s.ToLower();          
                Console.WriteLine(s);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null exception guys");
            }
        }
    }
}
