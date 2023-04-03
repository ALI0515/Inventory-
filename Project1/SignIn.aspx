<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
     <meta charset ="utf-8"/>
    <meta name="description" content="Free" />
    <meta name="keywords" content="HTML,CSS,XML,JavaScript" />
    <meta name="author" content="Ali Hiader" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    <link href="wwwroot/CSS/Header.css" rel="stylesheet" text="text/css" />
    <link href="wwwroot/CSS/Login.css" rel="stylesheet" text="text/css" />
    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link href="wwwroot/CSS/w3.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
           <div class="wrapper">
               <h1>Login Form</h1>
               <nav>
                   <ul>
                       <li><a href="#">Home</a></li>
                       <li><a href="#">Portfolio</a></li>
                       <li><a href="#">Contact</a></li>
                       <li><a href="#">Sign In</a></li>
                   </ul>
               </nav>
           </div>
       </header>

            <h2 class="w3-center">SignIn</h2>
 <div class="container w3-center" style="width:50%;margin-left:300px;" aria-disabled="false">
<div class="w3-row w3-section">
  <div class="w3-col" style="width:50px"><i class="w3-xxlarge fa fa-user"></i></div>
    <div class="w3-rest">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <contentTemplate>
            <asp:TextBox ID="txtUserName" runat="server" class="w3-input w3-border w3-border w3-round-large w3-amber" placeholder="UserName" AutoPostBack="true" OnTextChanged="txtUserName_TextChanged"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </contentTemplate>
            </asp:UpdatePanel>
        
    </div>
</div>

<div class="w3-row w3-section">
  <div class="w3-col" style="width:50px"><i class="w3-xxlarge fa fa-lock"></i></div>
    <div class="w3-rest">
      <asp:TextBox ID="txtPassword" runat="server" class="w3-input w3-border w3-border w3-round-large w3-amber" placeholder="Password" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Password is Empty" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
</div>

<div class="w3-row w3-section">
  <div class="w3-col" style="width:50px"><i class="w3-xxlarge fa fa-lock"></i></div>
    <div class="w3-rest">
      <asp:TextBox ID="txtConfirmPassword" runat="server" class="w3-input w3-border w3-border w3-round-large w3-amber" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Confirm password is empty" ForeColor="Red" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
      <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Confirm password and Passowrd does not match" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:CompareValidator>
    </div>
</div>

     <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="w3-button w3-block w3-section w3-blue w3-ripple w3-padding" OnClick="btnsubmit_Click"/>
     </div>
        </div>
    </form>
</body>
</html>
