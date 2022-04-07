using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Donate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Component.IsLogedIn)
            {
                Line.InnerHtml += "<div class='alert alert-danger' role='alert'>Please Login To Be Able To Donate.</div>"; 
                SubmitB.Visible = false;
            }
        }

        protected void SubmitB_Click(object sender, EventArgs e)
        {
            var fileName = Upload.FileName.Substring(0, Upload.FileName.LastIndexOf(".") + 1) + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + Upload.FileName.Substring(Upload.FileName.LastIndexOf(".")); // make it unique ! 
            
            using (var entity = new donationEntities())
            {
                entity.goods.Add(new good
                {
                    Title = TitleT.Text,
                    Description = DescT.Text,
                    Image = fileName,
                    user = Component.user.Email
                   
                }); 
                entity.SaveChanges();
            }
            Upload.SaveAs(Server.MapPath("~/Goods/") + fileName);
            Line.InnerHtml += "<div class='alert alert-success' role='alert'>Thank you for your donation.</div>";
        }
    }
}