using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace newconn
{
    internal  class read 
    {

        public void read1()
        {
           
            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            int e_no;
            string e_name;
            string e_dep;
            string e_designation;
            int e_sal;
            string e_location;
            Console.WriteLine("entre the e_no no ");
            e_no = Convert.ToInt32(Console.ReadLine());
         
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("search", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_no", e_no);
            Console.WriteLine(" "+e_no);
            object read = new object();
           
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                //e_no = dr["e_no"];
                //e_dep = Console.ReadLine();
                //e_name = Console.ReadLine();
                //e_designation = Console.ReadLine();
                //e_sal = Convert.ToInt32(Console.ReadLine());
                //e_location =(Console.ReadLine());



                Console.WriteLine("emp no:-   "+ dr["e_no"]);
                Console.WriteLine("emp nme:-  " + dr["e_name"]);
                Console.WriteLine("emp dep:-   " +dr["e_dep"]);
                Console.WriteLine("emo designa : -" +dr["e_designation"]);
                Console.WriteLine("emp sal:-  " + dr["e_sal"]);
                Console.WriteLine("emp location :-" + dr["e_location"]);
                

            }

        }
    }
}