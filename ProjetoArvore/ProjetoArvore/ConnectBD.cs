using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArvore
{
    public class ConnectBD
    {
        public ConnectBD()
        {

        }
        public DataTable GetNomes(DataTable dt)
        {
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Database=Database1;Integrated Security=True";
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string query = "Select * from Especies";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
        public DataTable GetCaldeiras(DataTable dt)
        {
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Database=Database1;Integrated Security=True";
            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            string query = "Select * from Construcao";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }
    }
}
