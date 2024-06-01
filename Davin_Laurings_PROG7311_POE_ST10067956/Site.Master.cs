using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    public partial class SiteMaster : MasterPage
    {
        string Category = "blank";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Category = Session["Category"].ToString();
                if (Category.Contains("Employee"))
                {
                    LoginLink.Visible = false;
                    Log_Off.Visible = true;
                    Farmer_Product.Visible = true;
                    Add_Farmer.Visible = true;
                }
                if (Category.Contains("Farmer"))
                {
                    LoginLink.Visible = false;
                    Log_Off.Visible = true;
                    Add_Product.Visible = true;
                }
            }
            catch { }
        }

        protected void MyMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            MenuItem clickedItem = e.Item;

            if (clickedItem.Text == "Log Off")
            {
                Category = null;
                Session.Clear();
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}