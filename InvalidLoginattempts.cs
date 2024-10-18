using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class InvalidLoginException:Exception
    {
        public string Message ;
        public InvalidLoginException(string message)
        {
            this.Message = message;
        }
    }
    internal class InvalidLoginattempts
    {
        public static void Main(string[] args)
        {
            string UserName = "Arun";
            int Password = 123;

            try
            {
                Console.WriteLine("Enter Username");
                string UName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                int PW = int.Parse(Console.ReadLine());
                if(UName.Equals(UserName) && PW == Password)
                {
                    Console.WriteLine("Login successfully");
                }
                else
                {
                    throw new InvalidLoginException("Invalid Login Attempts");
                }
            }catch(InvalidLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
