<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditHomePage.aspx.cs" Inherits="DemonSlayer.Admin.EditHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <asp:HyperLink ID="createPost" runat="server" NavigateUrl="~/post.aspx">Create New Post</asp:HyperLink>
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="PostID" DataSourceID="AllPostSQL">
    <Columns>
      <asp:BoundField DataField="PostID" HeaderText="PostID" InsertVisible="False" 
        ReadOnly="True" SortExpression="PostID" />
      <asp:BoundField DataField="UserID" HeaderText="UserID" 
        SortExpression="UserID" />
      <asp:BoundField DataField="Post" HeaderText="Post" SortExpression="Post" />
      <asp:hyperlinkfield headertext="Edit" text="Edit" navigateurl="~/post.aspx"
            datanavigateurlfields="PostID"
            datanavigateurlformatstring="~/post.aspx?PostID={0}" />
    </Columns>
  </asp:GridView>
  <asp:SqlDataSource ID="AllPostSQL" runat="server" 
    ConnectionString="<%$ ConnectionStrings:strConn %>" 
    SelectCommand="SELECT * FROM [Posts]"></asp:SqlDataSource>
</asp:Content>
