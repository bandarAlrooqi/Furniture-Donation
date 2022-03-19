<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASP.NET.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Register</h1>
                <div class="form-group">
                <label for="tName">Name</label>
                <asp:TextBox ID="tName" runat="server" placeholder="Mohammed" data-rule-email="true" class ="form-control" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email</label>
                <asp:TextBox ID="tEmail" runat="server" placeholder="Email" data-rule-email="true" class ="form-control" required="true"></asp:TextBox>
                <asp:Label runat="server" ID="Lerror" ForeColor="Red" Visible="False"></asp:Label>
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox ID="tPassword" runat="server" placeholder="Password" class="form-control" type="password" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                <label for="password2">Confirm Password</label>
                <asp:TextBox ID="tPasswordConfirm" runat="server" placeholder="Confirm Password" class="form-control" type="password" required="true"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tPassword" ControlToValidate="tPasswordConfirm" ErrorMessage="Password must be the same" CssClass="ValidationError" Display="Dynamic" ForeColor="Red" ToolTip="Password must be the same"></asp:CompareValidator>
                </div>
                 <div class="form-group">
                <label for="Phone">Phone</label>
&nbsp;<asp:TextBox ID="Phone" runat="server" placeholder="Ex:05xxxxx" class="form-control" type="number" required="true"></asp:TextBox>
                </div>
                     <div class="form-group">
                <label for="Address">Address</label>
                <asp:TextBox ID="Address" runat="server" placeholder="Ex:Saudi Arabia .." class="form-control" required="true"></asp:TextBox>
                </div>
                 <div class="form-group">
                <label for="Type">Type</label>
                 <asp:DropDownList ID="TypeList" runat="server" required="true" class="form-control">
                     <asp:ListItem disabled>Please Select</asp:ListItem>
                     <asp:ListItem>Dooner</asp:ListItem>
                     <asp:ListItem>Needy</asp:ListItem>
                 </asp:DropDownList>
                </div>
    <div class="form-group">
    <asp:Button ID="Submit" runat="server" type="submit" value="Log in" class="btn btn-primary" Text="Submit" OnClick="Submit_Click"/>
</div>
</asp:Content>
