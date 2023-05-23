using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconn
{
    internal class insert 
    {
        public void show()
        {
            int e_no = 0;
            string e_name;
            string e_dep;
            string e_designation;
            int e_sal;
            string e_location;
            Console.WriteLine("enter the emp no ");
            e_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e_no.GetType().Name);
            Console.WriteLine("enter the name");
            e_name = Console.ReadLine();
            Console.WriteLine(e_name.GetType().Name);
            Console.WriteLine("enter the dep ");
            e_dep = Console.ReadLine();
            Console.WriteLine(e_dep.GetType().Name);
            Console.WriteLine("enter the designation");
            e_designation = Console.ReadLine();
            Console.WriteLine(e_designation.GetType().Name);
            Console.WriteLine("enter the sal ");
            e_sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e_sal.GetType().Name);
            Console.WriteLine("enter the loction");
            e_location = Console.ReadLine();
            Console.WriteLine(e_location.GetType().Name);
            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("addele", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            object insert = new object();



            cmd.Parameters.AddWithValue("@e_no", e_no);
            cmd.Parameters.AddWithValue("@e_name", e_name);
            cmd.Parameters.AddWithValue("@e_dep", e_dep);
            cmd.Parameters.AddWithValue("@e_designation", e_designation);
            cmd.Parameters.AddWithValue("@e_sal", e_sal);
            cmd.Parameters.AddWithValue("@e_location", e_location);
            cmd.ExecuteNonQuery();
            Console.WriteLine("********** DATA INSERTED SUCESSFULLY **********");



        }
    }
    
}
