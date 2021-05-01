using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Movies_Manager_Application
{
    public abstract class DatabaseManager
    {
        /// <summary>
        /// Attempts to connect to the database using the connection string
        /// </summary>
        /// <returns>An open connection to the database</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Initial Catalog"] = "CSCI1630";
            builder["Data Source"] = "coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
            builder["User ID"] = "rw1630";
            builder["Password"] = "Project!";
            try
            {
                SqlConnection conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static bool ExistsMovie(Movie m)
        {
            SqlConnection conn = DatabaseManager.GetConnection();
            string query = $"Select * from Movies where Id = {m.Id} or (Title = '{m.Title}' and Director = '{m.Director}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool res = reader.HasRows;
            conn.Close();
            return res;
        }

        public static int GetNewId()
        {
            SqlConnection conn = GetConnection();
            string query = "Select max(Id) AS Id from Movies;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            int res = r.GetInt32(0) + 1;
            conn.Close();
            return res;
        }

    }
}