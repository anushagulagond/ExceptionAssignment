using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class AgeInvalidException : Exception
    {
        public AgeInvalidException()
        { }
        public override string Message => "Age should be greater then or equal to 18";

    }
    internal class AgeCustomeExcep
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age of User Who needs to Vote");
            int Age=int.Parse(Console.ReadLine());
            try
            {
                if (Age >= 18)
                {
                    Console.WriteLine("Person is eligible for Voting");
                }
                else
                {
                    throw new AgeInvalidException();
                }
            }
            catch(AgeInvalidException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
