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
        static string page = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack && Request.UrlReferrer != null)
                page = Request.UrlReferrer.ToString();
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            using (var entity = new donationEntities())
            {
                string encreptedPassword = Component.Encryptor(tPassword.Text);
               var record = entity.users.FirstOrDefault(x => x.Email==tEmail.Text && x.Password == encreptedPassword);
               if(record == null)
                {
                    Line.InnerHtml = "<div class='alert alert-danger' role='alert'>Incorrect email or password.</div>";
                }
                else
                {
                    Component.IsLogedIn = true;
                    Component.user = record;
                    Response.Redirect(page == null?"default":page);
                }
            }

        }
    }
}