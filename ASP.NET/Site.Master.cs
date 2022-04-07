using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Web.HttpContext;

namespace ASP.NET
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Component.IsLogedIn)
                lnkLogIn.Text = "Login";
            else
                lnkLogIn.Text = "Logout";
        }

        protected void lnkLogIn_Click(object sender, EventArgs e)
        {
            if (Component.IsLogedIn)
            {
                Component.IsLogedIn = !Component.IsLogedIn;
                Current.Response.Redirect("Default.aspx");
            }
            else
                Current.Response.Redirect("Login.aspx");
        }
    }
}