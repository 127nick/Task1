using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace newconn
{
    internal class readop
    {
        private static string strcon;

        public static void read()
        {
            int e_no;
            Console.WriteLine("enter the emp no");
            e_no = Convert.ToInt32(Console.ReadLine());
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("empsearch1",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@e_no", e_no) ;
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {}
        }
    }
}