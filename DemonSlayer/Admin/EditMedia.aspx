<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditMedia.aspx.cs" Inherits="DemonSlayer.Admin.EditMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div>
    <h2>Add Media.</h2>
  </div>
  <div>
    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
  </div>
  <div>
    <asp:FileUpload ID="fupMedia" runat="server" />
  </div>
  <div>
    <asp:Button ID="btnUploadMedia" runat="server" Text="Save" 
      onclick="btnUploadMedia_Click" />
  </div>
</asp:Content>
