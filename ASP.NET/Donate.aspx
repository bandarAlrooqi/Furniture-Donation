<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="ASP.NET.Donate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Donate</h2>
        <hr ID="Line" runat="server" />
    <div class="mb-3">
        <label for="TitleT">Title</label>
    <asp:TextBox ID="TitleT" runat="server" placeholder="Chair" class="form-control" required="true"></asp:TextBox>
         </div>
        <div class="mb-3">
            <label for="DescT">Description</label>
    <asp:TextBox ID="DescT" TextMode="MultiLine" runat="server" placeholder="Used chair in a good condiation !" class="form-control" required="true"></asp:TextBox>
            </div>
        <div class="mb-3">
            <label>Image</label>
    <asp:FileUpload ID="Upload" runat="server"  class="form-control" type="file" required="true" accept="image/*"/>
            </div>
    <asp:Button ID="SubmitB" runat="server" Text="Donate" class="btn btn-primary" required="true" OnClick="SubmitB_Click" />
</asp:Content>
