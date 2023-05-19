using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethod
{
    static class MYstaticlass
    {
        public static void func3( this Program p)
        {
            Console.WriteLine("this is  3rd fuction ");
        }
    }
}
