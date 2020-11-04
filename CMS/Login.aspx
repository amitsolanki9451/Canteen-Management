<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CMS.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <title> Login</title>
        <style type="text/css">
            .parallax_box .parallax_box_img {
    background-size: 120%;
}
.parallax_box .parallax_box_img {
    background-size: 106%;
    background-position: center top;
}
.parallax_box .parallax_box_img {
    background-attachment: fixed;
    background-size: 100%;
    background-position: 0 0;
    width: 100%;
    height: 100%;
    position: absolute;
    background-repeat: no-repeat;
    z-index: 0;
}
.parallax_box_img {
    background-repeat: no-repeat;
    background-size: 100%;
}
.company_profile_banner {
    background-size: 100% !important;
}
.jarallax, .parallax_box {
    min-height: 420px;
}
        </style>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/vendor/bootstrap/css/bootstrap.min.css"/>
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/vendor/animate/animate.css"/>
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/vendor/css-hamburgers/hamburgers.min.css"/>
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/vendor/select2/select2.min.css"/>
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Styles/Login/css/util.css"/>
    <link rel="stylesheet" type="text/css" href="Styles/Login/css/main.css"/>

    <!--===============================================================================================-->
</head>
<body>
       <div class="limiter">
         
         <div class ="company_profile_banner parallax_box" style="background-image: url('Styles/Login/images/banner.jpg')"></div>
           
           
           <div class="container-login100">
              
            <div class="wrap-login100">
               
                <div class="login100-pic js-tilt">
           <%--         <img src="Styles/Login/images/HILLogo.jpg" alt="IMG" />--%>
                        
                       <img src="Styles/Login/images/CMS INTERFACE-5.jpg" alt="IMG" style="width:400px;height:300px" />
                   
                </div>

                <form class="login100-form validate-form" runat="server">
                    <span class="login100-form-title">Member Login
                    </span>

                    <div class="wrap-input100 validate-input" data-validate="Valid email is required: ex@abc.xyz">


                        <asp:TextBox ID="txtUserName" CssClass="input100" runat="server" name="email" placeholder="UserName" autocomplete="off"></asp:TextBox>

                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <i class="fa fa-envelope" aria-hidden="true"></i>
                        </span>
                    </div>

                    <div class="wrap-input100 validate-input" data-validate="Password is required">
                     
                        <asp:TextBox ID="txtPassword" CssClass="input100" runat="server" autocomplete="off" onpaste="return false" TextMode="Password" placeholder="Password"></asp:TextBox>
                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <i class="fa fa-lock" aria-hidden="true"></i>
                        </span>
                    </div>
                    
                    <div class="container-login100-form-btn">
                        
                         <asp:Button ID="btnLogin" runat="server" CommandName="Login"  Text="Login" Width="149px" CssClass="login100-form-btn" OnClick="btnLogin_Click" ValidationGroup="Login1" />
                    </div>

                    <div class="text-center p-t-12">
                        
                        

                    </div>

                    <div class="text-center p-t-136">
                       
                    </div>
                </form> 
            </div>
               </div>
        </div>
              
  


       

    <!--===============================================================================================-->
    <script src="Styles/Login/vendor/jquery/jquery-3.2.1.min.js"></script>
   
    <%-- <script src="Styles/Login/js/main.js"></script>--%>
    <!--===============================================================================================-->
    <script src="Styles/Login/vendor/bootstrap/js/popper.js"></script>
    <script src="Styles/Login/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="Styles/Login/vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="Styles/Login/vendor/tilt/tilt.jquery.min.js"></script>
    <script>
        $('.js-tilt').tilt({
            scale: 1.1
        })
    </script>
    <!--===============================================================================================-->
  
</body>
</html>

