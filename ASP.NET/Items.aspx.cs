using System;
using System.Linq;
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
            CreateControls();
        }
        protected void CreateControls()
        {

            using (var entity = new donationEntities())
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
                        cardBody.InnerHtml += "<em>Requested by: " + GetUserName(item.RequestedBy) + "</em>";
                    else if (Component.IsLogedIn && item.user == Component.user.Email)
                    {
                        cardBody.InnerHtml += "<em>Posted by: you </em>";
                    }
                    else if (Component.IsLogedIn)
                    { // request button
                        var button = new Button();
                        button.Text = "Request";
                        button.Attributes["class"] = "btn btn-primary";
                        
                        button.CommandArgument = item.Id.ToString();
                        button.Click += new EventHandler(Request_click);
                       
                        cardBody.Controls.Add(button);
                    }
                    if (Component.IsLogedIn && (item.user == Component.user.Email || Component.user.Type == "Admin"))
                    {
                        var buttonD = new Button();
                        
                        buttonD.Text = "Delete";
                        buttonD.Attributes["class"] = "btn btn-danger float-right";
                        buttonD.UseSubmitBehavior = !true;
                        buttonD.ID = item.Id.ToString();
                        buttonD.CommandArgument = item.Id.ToString();
                        buttonD.Click += new EventHandler(Delete_click);
                        buttonD.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                        buttonD.OnClientClick = "if ( !confirm('Are you sure you want to delete this item ("+item.Title+") ?')) return false;";
                        cardBody.Controls.Add(buttonD);
                    }
                    card.Controls.Add(cardBody);
                    head.Controls.Add(card);
                    Items.Controls.Add(head);
        }
    }
        protected void Request_click(object sender, EventArgs e)
        {
            try
            {
                using (var entity = new donationEntities())
                {
                    string value = (sender as Button).CommandArgument;
                    var item = entity.goods.FirstOrDefault(id => value == id.Id.ToString());
                    item.Status = "Not Available";
                    item.RequestedBy = Component.user.Email;
                    entity.SaveChanges();
                    Response.Redirect("~/Items");
                   
                    

                }
            }catch (Exception ex) { } // error may be thrown in case of postback, we will just ignore it 
        }
        protected void Delete_click(object sender, EventArgs e)
        {
            try
            {
                using (var entity = new donationEntities())
                {
                    string value = (sender as Button).CommandArgument;
                    
                    entity.goods.Remove(entity.goods.FirstOrDefault(id => value == id.Id.ToString()));
                   
                    entity.SaveChanges();
                   
                    Response.Redirect("~/Items");

                }
            }
            catch (Exception ex) { } // error may be thrown in case of postback, we will just ignore it 
        }
        private string GetUserName(string email)
        {
            using (var entity = new donationEntities())
            {
                return entity.users.FirstOrDefault(e => e.Email == email).Name;
            }
        }
    }
}