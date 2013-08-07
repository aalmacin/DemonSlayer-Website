<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="DemonSlayer.post" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div>
   <asp:TextBox ID="txtPost" TextMode="MultiLine" runat="server"></asp:TextBox>
  </div>
  <asp:button id="btnSave" runat="server" text="Save" onclick="btnSave_Click" />
</asp:Content>
