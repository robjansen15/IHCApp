<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="IHCApp.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Admin Login</title>
    
    <!-- Bootstrap CSS -->    
    <link href="WebAssets/nice-assets/css/bootstrap.min.css" rel="stylesheet" />
    <!-- bootstrap theme -->
    <link href="WebAssets/nice-assets/css/bootstrap-theme.css" rel="stylesheet" />
    <!--external css-->
    <!-- font icon -->
    <link href="WebAssets/nice-assets/css/elegant-icons-style.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles -->
    <link href="WebAssets/nice-assets/css/style.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/style-responsive.css" rel="stylesheet" />
</head>

  <body class="login-img3-body">

    <div class="container">

      <form class="login-form"  runat="server">        
        <div class="login-wrap">
            <p class="login-img"><i class="icon_lock_alt"></i></p>
            <div class="input-group">
              <span class="input-group-addon"><i class="icon_profile"></i></span>
                <asp:TextBox runat="server" id="username" class="form-control" placeholder="Username"></asp:TextBox>
            </div>
            <div class="input-group">
                <span class="input-group-addon"><i class="icon_key_alt"></i></span>
                <asp:TextBox runat="server" id="password" class="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
            </div>
            <label class="checkbox">
                <input type="checkbox" value="remember-me" />Remember me
                <span class="pull-right"> <a href="#"> Forgot Password?</a></span>
            </label>
            <Asp:LinkButton runat="server" ID="loginBtn" OnClick="loginBtn_Click" class="btn btn-primary btn-lg btn-block" Text="Login"></Asp:LinkButton>
            <button class="btn btn-info btn-lg btn-block" type="submit">Signup</button>
        </div>
      </form>
    <div class="text-right">
            <div class="credits">
               
            </div>
        </div>
    </div>
      
  

  </body>
</html>
