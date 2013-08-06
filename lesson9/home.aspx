<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="lesson9.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

This is the home page.<asp:GridView ID="GridView1" runat="server" 
    AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
    DataKeyNames="PostID" DataSourceID="PostsSQL">
    <Columns>
      <asp:BoundField DataField="UserID" HeaderText="UserID" 
        SortExpression="UserID" />
      <asp:BoundField DataField="Post" HeaderText="Post" SortExpression="Post" />
      <asp:BoundField DataField="PostID" HeaderText="PostID" InsertVisible="False" 
        ReadOnly="True" SortExpression="PostID" />
    </Columns>
  </asp:GridView>
  <asp:SqlDataSource ID="PostsSQL" runat="server" 
    ConnectionString="<%$ ConnectionStrings:strConn %>" 
    SelectCommand="SELECT [UserID], [Post], [Timestamp], [PostID] FROM [Posts]">
  </asp:SqlDataSource>
&nbsp;

</asp:Content>
