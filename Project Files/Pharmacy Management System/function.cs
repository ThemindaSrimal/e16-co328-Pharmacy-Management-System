using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Pharmacy_Management_System
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            //"data source = S3DW\\SQLEXPRESS;database=PharmacyManagementSystem;integrated security = True";
            // load connection string from app.config
            string connString = ConfigurationManager.ConnectionStrings["Pharmacy_Management_System.Properties.Settings.PharmacyManagementSystemConnectionString"].ConnectionString;
            
            SqlConnection con = new SqlConnection(connString);

            return con;
        }

        public Boolean CheckConnection()
        {
            // check database connection
            try
            {
                SqlConnection con = GetConnection();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                con.Close();
                return true;
            } catch (Exception ex)
            {
                return false;
            } 
        }

        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String msg)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }
    }
}
