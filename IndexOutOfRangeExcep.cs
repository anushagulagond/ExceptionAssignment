using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class IndexOutOfRangeExcep
    {
        public static void Main(string[] args)
        {
            int[] MyArray = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Which index element do you need");
            int index=int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(MyArray[index]);
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
