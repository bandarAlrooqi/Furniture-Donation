using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit_Click(object sender, EventArgs e)
        {
            using (var entity = new donationEntities())
            {
                var record = entity.users.FirstOrDefault(x => x.Email==tEmail.Text && x.Password==tPassword.Text);
               if(record == null)
                {
                    Lerror.Visible = true;
                    Lerror.Text = "Incorrect email or password.";
                }
                else
                {
                    Component.IsLogedIn = true;
                    Lerror.Visible = !true;
                    Response.Redirect("default.aspx");
                }
            }

        }
    }
}