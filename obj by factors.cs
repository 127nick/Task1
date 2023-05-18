using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        public void Calc(int n, ref int f)
        {
            for (int i = 0; i < n;i++)
            {
                f=f*i;
            }


        }

            static void Main(string[] args)
            {
                int n,f;
                f = 1;
                Console.WriteLine("enter the number");
                n = Convert.ToInt32(Console.ReadLine());
                Program obj = new Program();
                 obj.Calc(n, ref f);
            Console.WriteLine("factors valu", +f);
            }
        

    }
}

