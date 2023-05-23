using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;
using System.Management.Instrumentation;
using System.Globalization;
using System.Data;

namespace date1
{
    internal class Program
    {

        class program { }



        static void Main(string[] args)
        {
            int e_no = 0;
            string e_salary = null;
            string e_name = null;
            string e_dep = null;
            string e_designation = null;
            string e_location = null;


            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(strcon);
            connection.Open();
            SqlCommand cmd = new SqlCommand("prc22", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                Console.WriteLine(dr["e_no"]);
                Console.WriteLine(dr["e_name"]);
                Console.WriteLine(dr["e_dep"]);
                Console.WriteLine(dr["e_designation"]);
                Console.WriteLine(dr["e_sal"]);
                Console.WriteLine(dr["e_location"]);
                Console.WriteLine(dr["e_name"]);



                Console.WriteLine("********** record inserted sucessfully");
                //Console.ReadKey();



            }
            connection.Close();
            SqlConnection connection1 = new SqlConnection(strcon);
            connection1.Open();

            Console.WriteLine("enter the emp no");
            e_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the emp name");
            e_name = (Console.ReadLine());
            Console.WriteLine("enter the e_dep"); 

            e_dep = (Console.ReadLine());
            Console.WriteLine("enter the emp designation");
            e_designation = (Console.ReadLine());
            Console.WriteLine("enter the sal ");
            e_salary = (Console.ReadLine());
            Console.WriteLine("Enter the loction of the emp ");
            e_location= (Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("prc22", connection1);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@e_no", e_no);
            cmd1.Parameters.AddWithValue("@e_name", e_name);
            cmd1.Parameters.AddWithValue("@e_dep", e_dep);
            cmd1.Parameters.AddWithValue("@e_designation", e_designation);
            cmd1.ExecuteNonQuery();
            
 
        }
    }


}
