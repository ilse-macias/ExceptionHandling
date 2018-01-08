using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 5;
            int denominator = 0;
            int result = 10; 
            /*Code we want to execute*/
            try
            {
                if(denominator == 0)
                {
                    throw new DivideByZeroException("Error");
                }
                result = numerator / denominator;
               // Console.WriteLine(result);
            }

            /*Define the exceptions*/
            catch (DivideByZeroException e) //It is recomendable to add the specific exception. The last option should be "Exception"
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Mas errir");
                /*It will print the exception message, it's not necesary to add "Message", but it's required to see the console clear.
                 That is the reason we use the variable.
                 */
            }

            /*Always be execute*/
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}
