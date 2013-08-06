<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="DemonSlayer.Admin.ControlPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<p>Control Panel Page</p>

<div>
    <asp:HyperLink ID="EditUsersLink" 
                   runat="server"
                   Text="Edit Users"
                   NavigateUrl="~/Admin/EditUsers.aspx"
                   ></asp:HyperLink> <br>
    <asp:HyperLink ID="EditHomePageLink" 
                   runat="server"
                   Text="Edit Homepage"
                   NavigateUrl="~/Admin/EditHomePage.aspx"
                   ></asp:HyperLink><br>
    <asp:HyperLink ID="EditMediaLink" 
                   runat="server"
                   Text="Edit Media"
                   NavigateUrl="~/Admin/EditMedia.aspx"
                   ></asp:HyperLink><br>
</div>
</asp:Content>
