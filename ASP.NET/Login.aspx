<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP.NET.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text">Login</h2>
        <hr runat="server" ID="Line"/>
            <div class="mb-3">
                <label for="email">Email</label>
                <asp:TextBox ID="tEmail" runat="server" placeholder="email@donate.com" class="form-control" required="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="password">Password</label>
                <asp:TextBox ID="tPassword" runat="server" placeholder="********" class="form-control" type="password" required="true"></asp:TextBox>
                </div>
    <div class="mb-3">
    <asp:Button ID="submit" runat="server" type="submit" value="Log in" class="btn btn-primary" Text="Login" OnClick="submit_Click"/>
</div>
     <p>No account yet? <a href="Register.aspx">Register</a> Now</p>
</asp:Content>
