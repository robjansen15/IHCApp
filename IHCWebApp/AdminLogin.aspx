<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="UserWebApp.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    
    <!-- Bootstrap CSS -->    
    <link href="/nice-assets/css/bootstrap.min.css" rel="stylesheet" />
    <!-- bootstrap theme -->
    <link href="/nice-assets/css/bootstrap-theme.css" rel="stylesheet" />
    <!--external css-->
    <!-- font icon -->
    <link href="/nice-assets/css/elegant-icons-style.css" rel="stylesheet" />
    <link href="/nice-assets/css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles -->
    <link href="/nice-assets/css/style.css" rel="stylesheet" />
    <link href="/nice-assets/css/style-responsive.css" rel="stylesheet" />
</head>
  <body class="login-img3-body">

    <div class="container">

      <form class="login-form"  runat="server">        
        <div class="login-wrap">
            <p class="login-img"><i class="icon_lock_alt"></i></p>
            <div class="input-group">
              <span class="input-group-addon"><i class="icon_profile"></i></span>
                <input type="text" class="form-control" placeholder="Username" autofocus />
            </div>
            <div class="input-group">
                <span class="input-group-addon"><i class="icon_key_alt"></i></span>
                <input type="password" class="form-control" placeholder="Password" />
            </div>
            <label class="checkbox">
                <input type="checkbox" value="remember-me" />Remember me
                <span class="pull-right"> <a href="#"> Forgot Password?</a></span>
            </label>
            <button class="btn btn-primary btn-lg btn-block" type="submit">Login</button>
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
