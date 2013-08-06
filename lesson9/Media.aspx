<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Media.aspx.cs" Inherits="lesson9.Media" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div>
    <h2>Media.
    </h2>
  </div>
  <div>
    <asp:DataList ID="DataList1" runat="server" BackColor="White" 
      BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
      DataSourceID="MediaSQL" Font-Bold="False" Font-Italic="False" 
      Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
      ForeColor="Aqua" GridLines="Horizontal" RepeatDirection="Horizontal" 
      RepeatLayout="Flow">
      <AlternatingItemStyle BackColor="#F7F7F7" />
      <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
      <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
      <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
      <ItemTemplate>
        UserID:
        <asp:Label ID="UserIDLabel" runat="server" Text='<%# Eval("UserID") %>' />
        <br />
        Title:
        <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
        <br />
        <asp:Label ID="LocationLabel" runat="server" Text='' />
        <asp:HyperLink ID="dlFile" runat="server" NavigateUrl='<%# Eval("Location") %>'>View File</asp:HyperLink>
        <br />
        <br />
      </ItemTemplate>
      <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    </asp:DataList>
  </div>
  <div>
  <asp:SqlDataSource ID="MediaSQL" runat="server" 
    ConnectionString="<%$ ConnectionStrings:strConn %>" 
    
      
      SelectCommand="SELECT [UserID], [Title], [Location] FROM [Media] ORDER BY [Timestamp]">
  </asp:SqlDataSource>
  </div>
</asp:Content>