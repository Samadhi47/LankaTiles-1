using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LankaTiles
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
      
       
        public Database()
        {
            con = new SqlConnection("Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles;Integrated Security=True");
           
        }
        public String getValue(String query)
        {
            String foundValue = "";
            using (con)
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foundValue = reader[0].ToString();
                        }
                    }
                }
            }
            con.Close();
            return foundValue;
        }
       
        public void inserUpdateDelete(String query)
        {
            con.ConnectionString = "Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable select(String query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
