<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditHomePage.aspx.cs" Inherits="lesson9.Admin.EditHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
  <asp:TextBox ID="txtPost" TextMode="MultiLine" runat="server"></asp:TextBox>
</div>
<div>
  <asp:Button ID="btnPost" runat="server" Text="Post" onclick="btnPost_Click" />
</div>
</asp:Content>
