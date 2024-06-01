using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    public class DatabaseHandler
    {
        //Using the connection string in the web.config file
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        User user = null;
        public string Status {  get; set; }

        //------------------------------------------------------------------------

        /// <summary>
        /// Saving the user's info to the User class to be used at a later stage
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        //------------------------------------------------------------------------

        public User GetUserInfo(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Surname, Category, Email FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user.ID = Convert.ToInt32(reader["ID"]);
                                user.Name = reader["Name"].ToString();
                                user.Surname = reader["Surname"].ToString();
                                user.Username = username;
                                user.Password = password;
                                user.Category = reader["Category"].ToString();
                                user.Email = reader["Email"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return user;
        }

        //------------------------------------------------------------------------

        /// <summary>
        /// Checking if the Username and Password are correct
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>

        //------------------------------------------------------------------------

        public void CheckUserInfo(string Username, string Password)
        {
            int matchingUserCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        matchingUserCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                if (matchingUserCount > 0)
                {
                    GetUserInfo(Username, Password);
                }
                else 
                {
                    Status = "False";
                }
            }
        }

        //------------------------------------------------------------------------

    }

}

//---------------------------------------------------end-------------------------------------------------------