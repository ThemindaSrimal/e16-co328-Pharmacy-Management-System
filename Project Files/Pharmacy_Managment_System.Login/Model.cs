using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pharmacy_Managment_System.Core
{
    public class Model
    {
        protected SqlConnection GetConnection()
        {

            // load connection string from app.config
            string connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

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
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetData(string query)
        {
            // get data from database according to query
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public Boolean SetData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand
            {
                Connection = con
            };
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public String AddUser(
            String role,
            String fullName,
            String dob,
            String email,
            Int64 mobile,
            String username,
            String address,
            String password,
            String otherDetails
            )
        {
            

            String query = "insert into users (userRole,fullName,dob,addres,mobile,email,username,pass,otherDetails) values('"
                + role
                + "','"
                + fullName
                + "','"
                + dob
                + "','"
                + address
                + "',"
                + mobile
                + ",'"
                + email
                + "','"
                + username
                + "','"
                + password
                + "','"
                + otherDetails
                + "')";

            return query;
        }


        
    }
}
