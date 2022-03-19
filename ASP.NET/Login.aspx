<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP.NET.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <section class="vh-100">
    <h1>Login</h1>
            <div class="form-group">
                <label for="email"></label>
                <asp:Label runat="server" ID="Lerror" ForeColor="Red" Visible="False"></asp:Label>
                <asp:TextBox ID="tEmail" runat="server" placeholder="Email" class="form-control" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="password"></label>
                <asp:TextBox ID="tPassword" runat="server" placeholder="Password" class="form-control" type="password" required="true"></asp:TextBox>

                    
                </div>
    <div class="form-group">
    <asp:Button ID="submit" runat="server" type="submit" value="Log in" class="btn btn-primary" Text="Submit" OnClick="submit_Click"/>
</div>
        <div class="form-group">
     <a href="Register.aspx">No account yet? Register Now</a>
    </div>

    </section>
</asp:Content>
