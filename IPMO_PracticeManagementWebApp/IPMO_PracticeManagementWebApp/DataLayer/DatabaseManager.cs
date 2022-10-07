using IPMO_PracticeManagementWebApp.Model;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IPMO_PracticeManagementWebApp.DataLayer
{
    public class DatabaseManager
    {
        private SqlConnection Conn;
        private void CreateConnection()
        {
            //string ConnStr = "Server=tcp:ipmo-practicemanagementsever.database.windows.net,1433;Initial Catalog=IPMO_PracticeManagementDB;Persist Security Info=False;User ID=Glenn;Password=Isena@12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString.ToString();

            Conn = new SqlConnection(ConnStr);
        }

        public DataTable GetInformationHeaders(string dbQuery = "")
        {
            CreateConnection();

            string query = dbQuery;

            string SqlString = query;
            SqlDataAdapter sda = new SqlDataAdapter(SqlString, Conn);
            DataTable dt = new DataTable();
            try
            {
                Conn.Open();
                sda.Fill(dt);
            }
            catch (SqlException se)
            {
                throw se;
            }
            finally
            {
                Conn.Close();
            }
            return dt;
        }

        public string AddUpdateDeleteData(string dbQuery)
        {
            CreateConnection();
            var comm = new SqlCommand(dbQuery, Conn);
            try
            {
                Conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return "ERROR : " + ex.Message;
            }
            finally
            {
                Conn.Close();
            }

            return "Success";
        }
    }
}