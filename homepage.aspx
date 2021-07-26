<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="Login_with_Master_Page.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="header"> Please enter you email and password</h1>
    <div class="login">    
    <form id="login" >    
        <label><b>User Name     
        </b>    
        </label>   
        <asp:TextBox ID="Uname" name="Uname" placeholder="Username" runat="server"></asp:TextBox>  
        <br><br>    
        <label><b>Password     
        </b>    
        </label>    
        <input type="Password" name="Pass" id="Pass" placeholder="Password">    
        <br><br>     
        <asp:Button ID="log" name="log" runat="server" Text="Log In Here" OnClick="log_Click" />
        <br><br>    
        <input type="checkbox" id="check">    
        <span>Remember me</span>    
        <br><br>    
        Forgot <a href="#">Password</a>   
        <asp:TextBox ID="msg" runat="server"></asp:TextBox>
    </form>     
</div>    
</asp:Content>
