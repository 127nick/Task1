using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    internal class Program
    {
        public void show()
        {
            int[] a = new int[] { 10, 11, 12, 13, 15, 16 };
            for (int i = 0; i <= a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main(string[] args)
        {
           Demo obj = new Demo();
            obj.show();
        }
    }
}
