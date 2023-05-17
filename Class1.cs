using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class emp
    {
        public void show(int empno, out string name, out double basic)
        {
            if (empno==1)
            {
                name = "nikhil";
                basic = 88995;

            }else if (empno==2) 
            {
                name = "nikam";
                basic = 99888;

            }else
            {
                name = "not found";
                basic = 0;

            }

        }
        static void Main(string[] args)
        {
            int empno = 1;
            string name;
            double basic;
        }

    }
}
