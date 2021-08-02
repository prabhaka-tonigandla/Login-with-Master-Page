<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Login_with_Master_Page.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="style.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="header"> Please enter you email and password</h1>
    <div class="login">    
        
        <label><b>User Name     
        </b>    
        </label>   
        <asp:TextBox runat="server" ID="txtUsername" name="Uname" placeholder="Username"></asp:TextBox>  
        <br><br>    
        <label><b>Password     
        </b>    
        </label>    
        <asp:TextBox runat="server" type="Password" name="Pass" ID="txtPassword" placeholder="Password"> </asp:TextBox> 
        <br><br>     
        <asp:Button ID="log" name="log" runat="server" Text="Log In Here" OnClick="log_Click" />
        <br><br>    
        <input type="checkbox" id="check">    
        <span>Remember me</span>    
        <br><br>    
        Forgot <a href="#">Password</a>   
        <br /><br />
        <div class="red">
             <asp:Literal ID="ltrMessage"   runat="server"></asp:Literal>
        </div>
       
         
</div>    
</asp:Content>
