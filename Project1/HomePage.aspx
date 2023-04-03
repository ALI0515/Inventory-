<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <meta name="viewport" content="width=device-width,initial-scale=1" />
    <style>
        div.scrollmenu{
            background-color:#333;
            overflow:auto;
            white-space:nowrap;
        }
        div.scrollmenu a{
            display:inline-block;
            color:white;
            text-align:center;
            padding:14px;
            text-decoration:none;
        }
        div.scrollmenu a:hover{
            background-color:#777;
        }
       
    </style>
</head>
<body>
 
    <form id="form1" runat="server">
        <div>
            <h2>
                <asp:ImageButton ID="ImageButton1" runat="server" width="80px" Height="80px" ImageUrl="~/wwwroot/images/useravtar.jpg"/>Welcome,&nbsp;<asp:Label ID="lblUser" runat="server" Text="Label" ForeColor="Green"></asp:Label>
            </h2>
            <hr />

            <div class="scrollmenu">
            <a href="#home">Home</a>
                <a href="">Add User</a>
                <a href="">ViewRecord</a>
                <a href="#about">About</a>
                <a href="#support">Support</a>
                <a href="#blog">Blog</a>
                <a href="#tools">Tool</a>
                <a href="#custom">Custom</a>
                <a href="#more">More</a>
                <a href="#Work">Work</a>
                <a href="logout.aspc">Logout</a>
            </div>
           
        </div>
    </form>
</body>
</html>
