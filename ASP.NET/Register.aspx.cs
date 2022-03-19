using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (var entity = new donationEntities())
            {
                entity.users.Add(new user
                {
                    Email = tEmail.Text,
                    Name = tName.Text,
                    Type = TypeList.SelectedValue,
                    Password = tPassword.Text,
                    phone = Phone.Text,
                    Address = Address.Text
                });
                try
                {
                    entity.SaveChanges(); // exception will occure in case of dublicated key 
                    Lerror.Visible = false;
                }
                catch (Exception ex)
                {
                    Lerror.Text = "Email address already exisit.";
                    Lerror.Visible = true;
                }
                
            }
           
            System.Diagnostics.Debug.WriteLine("ZG");
        }
    }
}