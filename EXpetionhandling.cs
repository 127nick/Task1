using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the first number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("  the division of two number is  ", +result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("the number cant niot be divide by  zero ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                int res1 = num1 * num2;
                Console.WriteLine("the mul of two fuction"+res1);
            }

            Console.WriteLine( " 1");
            Console.WriteLine( "2");
            Console.WriteLine("3");
            Console.ReadLine();
        }

    }
}
 
