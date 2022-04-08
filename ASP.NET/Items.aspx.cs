using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP.NET
{
    public partial class Goods : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Component.IsLogedIn)
            {
                Line.InnerHtml = "<div class='alert alert-secondary' role='alert'>Please Login To Be Able To Benift From These Items.</div>";
            }
            using (var entity = new donationEntities())
            {
                foreach (var item in entity.goods)
                {
                    if (Component.IsLogedIn && Component.user.Type != "Admin" && item.Status == "Not Available" || !Component.IsLogedIn && item.Status == "Not Available") continue;
                    var head = new HtmlGenericControl("div");
                    head.Attributes["class"] = "col";
                    var card = new HtmlGenericControl("div");
                    card.Attributes["class"] = "card";
                    // Image 
                    var img = new HtmlGenericControl("img");
                    img.Attributes["class"] = "card-img-top img";
                    img.Attributes["src"] = "https://localhost:44367/Goods/" + item.Image;
                    img.Attributes["width"] = "100px";
                    img.Attributes["height"] = "300px";
                    img.Attributes["alt"] = "Item image";
                    card.Controls.Add(img);
                    // Title and Descreption 
                    var cardBody = new HtmlGenericControl("div");
                    cardBody.Attributes["class"] = "card-body";
                    cardBody.InnerHtml = "<h5 class='card-title'>" + item.Title + "</h5> <hr>" + "<p class='card-text'>" + item.Description + "</p>";
                    if (item.Status == "Not Available")
                        cardBody.InnerHtml += "<em>Not Avaliable </em>";
                    else if(Component.IsLogedIn)
                    { // request button
                        var button = new Button();
                        button.Text = "Request";
                        button.Attributes["class"] = "btn btn-primary";

                        button.Click += new EventHandler(Request_click);

                        cardBody.Controls.Add(button);
                    }
                    if(Component.IsLogedIn && (item.user  == Component.user.Email  || Component.user.Type == "Admin"))
                    {
                        var buttonD = new Button();
                        buttonD.Text = "Delete";
                        buttonD.Attributes["class"] = "btn btn-danger float-right";
                        buttonD.Click += new EventHandler(Delete_click);
                        cardBody.Controls.Add(buttonD);
                    }
                    card.Controls.Add(cardBody);

                    head.Controls.Add(card);
                    Items.Controls.Add(head);
                    
                }
            }
        }
        protected void Request_click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Request CLICK ");
            Response.Redirect("~/Items");
        }
        protected void Delete_click(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("DELTE CLICK ");
            Response.Redirect("~/Items");
        }
    }
}