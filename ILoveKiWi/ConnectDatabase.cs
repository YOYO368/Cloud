using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace ILoveKiWi
{
    public class ConnectDatabase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionILoveKiWi"].ConnectionString;
        SqlConnection connection;

        public DataTable GetUserImformation()
        {
            string query;
            SqlCommand cmd;

            connection = new SqlConnection(connectionString);
            connection.Open();

            query = "select User_ID, User_Passwd,User_Name, User_Email,User_Mobile from tblCustomer_Info";
            cmd = new SqlCommand();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean CheckUserID_Password(string UserID, string UserPasswd)
        {
            SqlCommand command;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM tblCustomer_Info WHERE User_ID='" + UserID + "' AND User_Passwd='" + UserPasswd + "'";
            try
            {
                command = new SqlCommand(query, connection);
                var firstColumn = command.ExecuteScalar();
                if (firstColumn != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean CheckUserID(string userID)
        {
            SqlCommand command;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM tblCustomer_Info WHERE User_ID='" + userID + "'";

            try
            {
                command = new SqlCommand(query, connection);
                var firstColumn = command.ExecuteScalar();
                if (firstColumn != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public Boolean AddNewCustomer(string userID, string userPassword, string userName, string Email, string Mobile)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO tblCustomer_Info values('" + userID + "','" + userPassword + "','" + userName + "','" + Email + "','" + Mobile + "')";

            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}