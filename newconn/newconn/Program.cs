using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using NLog.Internal;
using System.Data.SqlClient;

namespace newconn
{
    internal class Program
    {
        private const int V = 8;

        static void Main(string[] args)
        {

            bool exit = false;

            string strcon = ConfigurationManager.ConnectionStrings["sqlparcticeconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("NewElem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();




            insert i = new insert();
            update u = new update();
            delete d = new delete();
            read r = new read();

            while (!exit)
            {
                Console.WriteLine("ENter your Choice.....");
                Console.WriteLine("\n1:Insert data \n2:Update records \n3:Delete record \n4: Display records ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        i.show();
                        break;
                    case 2:
                        u.ud();
                        break;
                    case 3:
                        d.dl();
                        break;
                    case 4:
                        r.read1();
                        break;
                    case 0:
                        exit = true;
                        break;



                }

            }
        }
    }
}
