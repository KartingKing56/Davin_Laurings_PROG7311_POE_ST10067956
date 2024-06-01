using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    public partial class My_Product : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection2"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve data from the database (replace with your actual query)
                DataTable dt = GetDataFromDatabase();

                // Bind the data to the GridView
                gridViewData.DataSource = dt;
                gridViewData.DataBind();
            }
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string SessionID = Session["Id"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MyTable WHERE SessionID = @SessionID", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}