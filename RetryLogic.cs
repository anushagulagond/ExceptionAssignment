using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class RetryLogic
    {
        public static void Main(string[] args)
        {
            int chance = 0;
            Console.WriteLine("Enter Integer");
            while (chance <= 3)
            {
                
                try
                {
                    int Result = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Result);
                }
                catch (FormatException e)
                {
                    if (chance < 3)
                    {
                        Console.WriteLine("Enter Valid Integer number");
                    }
                    else
                    {
                        Console.WriteLine(e.Message);  
                    }
                    chance++;
                }
                
            }
           
        }
    }
}
