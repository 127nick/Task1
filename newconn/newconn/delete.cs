using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconn
{
    internal class delete
    {
        public  void dl()
        {

            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            int e_no;
         
            Console.WriteLine("entre the e_no no ");
            e_no = Convert.ToInt32(Console.ReadLine());

            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("del2", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_no", e_no);
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("record deleter sceffuly");
            object delete = new object();

        }
    }
}
