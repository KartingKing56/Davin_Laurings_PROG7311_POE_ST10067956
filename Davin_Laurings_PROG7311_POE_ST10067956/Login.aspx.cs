using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Printing;

namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    public partial class Login : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection2"].ConnectionString;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "sp_Login";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.ToString());

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            Session["Username"] = txtUsername.Text.ToString();
                            Session["ID"] = reader["ID"].ToString();
                            Session["Category"] = reader["Category"].ToString();

                            Response.Redirect("~/Default.aspx");

                            reader.Close();
                            con.Close();
                        }
                        else
                        {
                            lblErrorMessage.Visible = true;
                        }
                        reader.Close();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}