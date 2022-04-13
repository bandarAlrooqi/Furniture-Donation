<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASP.NET.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Register</h2>
    <hr runat="server" id="Line"/>
                <div class="form-group">
                <label for="tName">Name</label>
                <asp:TextBox ID="tName" runat="server" placeholder="Mohammed" data-rule-email="true" class ="form-control" required="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Email</label>
                <asp:TextBox ID="tEmail" runat="server" placeholder="email@donate.com" data-rule-email="true" class ="form-control" required="true"></asp:TextBox>
               
                <asp:RegularExpressionValidator
        id="regEmail"
        ControlToValidate="tEmail"
        Text="Enter a valid email."
        Display="Dynamic" ForeColor="Red"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        Runat="server" />    
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox ID="tPassword" runat="server" placeholder="******" class="form-control" type="password" required="true"></asp:TextBox>
                <asp:RegularExpressionValidator ID="valPassword" runat="server" 
                 ControlToValidate="tPassword"
                 ErrorMessage="Password needs to be atleast 6 characters."
                 Display="Dynamic" ForeColor="Red"
                 ValidationExpression=".{6}.*" />
                </div>
                <div class="form-group">
                <label for="password2">Confirm Password</label>
                <asp:TextBox ID="tPasswordConfirm" runat="server" placeholder="******" class="form-control" type="password" required="true"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tPassword" ControlToValidate="tPasswordConfirm" ErrorMessage="Password must be the same" CssClass="ValidationError" Display="Dynamic" ForeColor="Red" ToolTip="Password must be the same"></asp:CompareValidator>
                </div>
                 <div class="form-group">
                <label for="Phone">Phone</label>
                     <asp:TextBox ID="Phone" runat="server" placeholder="05xxxxx" class="form-control" type="number" required="true"></asp:TextBox>
                     <asp:RegularExpressionValidator
        id="RegularExpressionValidator1"
        ControlToValidate="Phone"
        Text="Enter a valid phone number."
        Display="Dynamic" ForeColor="Red"
        ValidationExpression="^[0-9]{10}$" 
        Runat="server" />    
                </div>
                     <div class="form-group">
                <label for="Address">Address</label>
                <asp:TextBox ID="Address" runat="server" placeholder="Saudi Arabia .." class="form-control" required="true"></asp:TextBox>
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
