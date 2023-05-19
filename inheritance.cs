using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_demo
{ 
            class visiemp : emp
            {
                public int vistingsal;
                public int vistinghrs;
            }
            class peremp : emp
            {
                public int empsal;
                public int emphrs;
            }
            class emp
            {
                public int empid;
                public string name;
                public int age;
                public int contact_no;
            }
      
        class program {
            static void Main(string[] args)
            {
                peremp p= new peremp();   
                p.empid = 1;
                p.age = 2;  
                p.contact_no = 3;
                p.empsal = 4;
                p.emphrs = 5;
            


          

               Console.ReadLine
                ();


            }
        }
    }

