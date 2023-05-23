using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace newconn
{
    internal class update
    {
        public void ud()
        {


            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();

            Console.WriteLine("enter the privious id ");
            int e_no= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter the empoyee num");
            int e_no1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter the e_name");
            string e_name1 = (Console.ReadLine());


            Console.WriteLine("enter the e_dep");
            string e_dep1 = (Console.ReadLine());

            Console.WriteLine("enter the e_designation");
            string e_designation1 = (Console.ReadLine());

            Console.WriteLine("enter the e_sal");
            int e_sal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the e_location");
            string e_loaction1 = (Console.ReadLine());



            SqlCommand cmd = new SqlCommand("Up", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("e_no", e_no);
            cmd.Parameters.AddWithValue("@e_no1", e_no1);
            cmd.Parameters.AddWithValue("@e_name1", e_name1);
            cmd.Parameters.AddWithValue("@e_dep1", e_dep1);
            cmd.Parameters.AddWithValue("@e_designation1", e_designation1);
            cmd.Parameters.AddWithValue("@e_sal1", e_sal1);
            cmd.Parameters.AddWithValue("@e_loaction1", e_loaction1);
            cmd.ExecuteNonQuery();
            object update = new object();

            Console.WriteLine("the record added suceffully");




        }
    }

}
