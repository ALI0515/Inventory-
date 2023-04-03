<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <meta charset ="utf-8"/>
    <meta name="description" content="Free" />
    <meta name="keywords" content="HTML,CSS,XML,JavaScript" />
    <meta name="author" content="Ali Hiader" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0" />
    <link href="wwwroot/CSS/Header.css" rel="stylesheet" text="text/css" />
    <link href="wwwroot/CSS/Login.css" rel="stylesheet" text="text/css" />
    <script language="javascript" type="text/javascript">
        function msg() {
            var User = document.getElementById("txtUserName").value;
            var pass = document.getElementById("txtPassword").value;
            if (User == "" && pass == "") {
                alert("Username & Password can not be blank");
                document.getElementById("txtUserName").focus();
                return false;
            }
            else if (User == "") {
                alert("UserName must be filled");
                document.getElementById("txtUserName").focus();
                return false;
            }
            else if (pass == "") {
                alert("Password must be filled");
                document.getElementById("txtPassword").focus();
                return false;
            }
            else if (User.length<4) {
                alert("User name length must be 4 ");
                document.getElementById("txtUserName").focus();
                return false;
            }
            else if (pass.length < 4 || pass.length>=18) {
                alert("password length must be 4");
                document.getElementById("txtUserName").focus();
                return false;
            }
            return true; 
        }
        
        
    </script>
    <script>
        //autofill password
        function showPass() {
            var cookies = document.cookie;
            var allcookie = cookies.split(";");
            for (ctr = 0; ctr < allcookie.length; ctr++) {
                var dt = allcookie[ctr];
                var str = dt.split["="];
                //checking whether username ispresent in the cookie or not
                if (str[0].trim() == document.getElementById("txtUserName").value.trim()) {
                    document.getElementById("txtPassword").value = str[1];
                    break;
                }
            }
        }
    </script>
</head>
<body onload="showPass()">
    <form id="form1" runat="server">
        <!---This is header section--->
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
        <!--- Header section End here--->
        <div style="width:700px; margin-left:350px; margin-top:50px">
            <h2 style="text-align:center;background-color:lightgreen;padding:10px">Login Form</h2>

        </div>
        <div class="imgcontainer">
            <img src="wwwroot/images/security.png" alt="Avatar" class="avatar" />
        </div>
        <div class="container">
            <label for="uname"><b>UserName</b></label>
            <asp:TextBox ID="txtUserName" placeholder="Enter Username" runat="server"></asp:TextBox>

            <label for="psw"><b>Password</b></label>
            <asp:TextBox ID="txtPassword" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Login" Font-Size="Large" OnClick="Button1_Click" OnClientClick="return msg1();"/>
            <label>
                <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="Large" Text="Remember me" />
            </label>
        </div>
        <div class="container" style="background-color:#f1f1f1">
            <button type="button" class="cancelbtn">Cancel</button>
            <span class="psw"><a href="#">Password</a></span>
        </div>
        <br />
        
        <footer>
           <div class="wrapper">
               <div class="footer-info">
                   <p>Copyright@2020 CODER All rights reserved</p>
                   <p><a href="#">Terms of Service</a>|| <a href="#">Privacy</a></p>
               </div>
               <div class="footer-links">
                   <ul>
                       <li><h5>Home</h5></li>
                       <li><a href="#">Abous Us</a></li>
                       <li><a href="#">Meet the team</a></li>
                       <li><a href="#">What we do</a></li>
                       <li><a href="#">Carrers</a></li>
                   </ul>
                     <ul>
                       <li><h5>Company</h5></li>
                       <li><a href="#">Abous Us</a></li>
                       <li><a href="#">Meet the team</a></li>
                       <li><a href="#">What we do</a></li>
                       <li><a href="#">Carrers</a></li>
                   </ul>
               </div>
           </div>
        </footer>
           
    </form>
</body>
</html>
