<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="Login_with_Master_Page.AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Welcome Admin</h1>
   <asp:GridView runat="server" ID="ProductsGrid" 
                AutoGenerateColumns="false"
                ItemType="Login_with_Master_Page.ProductDTO"
                SelectMethod="GetData"
                AllowSorting="true" 
                AllowPaging="true" PageSize="20">
    <Columns>
        <asp:BoundField HeaderText="Product" DataField="Title" SortExpression="Title" />
        <asp:BoundField HeaderText="Category" DataField="Category" SortExpression="Category" />
        <asp:BoundField HeaderText="Qty/Unit" DataField="QuantityPerUnit" SortExpression="QuantityPerUnit" />     
    </Columns>
</asp:GridView>
</asp:Content>
