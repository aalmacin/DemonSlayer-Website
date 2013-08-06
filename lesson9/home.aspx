<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="lesson9.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

This is the home page.
  <asp:SqlDataSource ID="PostsSQL" runat="server" 
    ConnectionString="<%$ ConnectionStrings:strConn %>" 
    
    SelectCommand="SELECT [UserID], [Post], [Timestamp], [PostID] FROM [Posts] ORDER BY [Timestamp] DESC">
  </asp:SqlDataSource>
&nbsp;
  <asp:DataList ID="postsDataList" runat="server" CellPadding="3" 
    DataKeyField="PostID" DataSourceID="PostsSQL" 
    RepeatDirection="Horizontal" RepeatLayout="Flow" BackColor="White" 
    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
    GridLines="Horizontal">
    <AlternatingItemStyle BackColor="#F7F7F7" />
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <ItemTemplate>
      <div>
        <h2><asp:Label ID="PostLabel" runat="server" Text='<%# Eval("Post") %>' /></h2>
        <p>Posted By: <asp:Label ID="UserNameLabel" runat="server" Text='<%# BusinessRules.CUser.getNameByID(Convert.ToInt32(Eval("UserID"))) %>' /></p>
        <br />
        <br />
      </div>
<br />
    </ItemTemplate>
    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
  </asp:DataList>
</asp:Content>