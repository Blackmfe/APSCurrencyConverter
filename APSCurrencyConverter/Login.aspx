<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="APSCurrencyConverter.Login" %>

<!DOCTYPE html>
<html>

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>VIRTUAL PAYMENT SOLUTIONS</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet">

    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

</head>

<body class="gray-bg">

    <div class="middle-box text-center loginscreen animated fadeInDown">
        <div>
            <div>

                <h1 class="logo-name">VPS</h1>

            </div>
            <h3>Welcome to VPS</h3>
            <p>Currency Converntion System</p>
            <asp:Label ID="lblerror" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            <form class="m-t" runat="server">
                <div class="form-group">
                    <asp:TextBox type="email" ID="txtusername" runat="server" class="form-control" placeholder="Email" required=""></asp:TextBox>
                </div>
                <div class="form-group">
                     <asp:TextBox type="password" ID="txtpassword" runat="server" class="form-control" placeholder="Password" required=""></asp:TextBox>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary block full-width m-b" OnClick="btnLogin_Click"/>
                <p class="text-muted text-center"><small>Not Registered?</small></p>
                <a class="btn btn-sm btn-white btn-block" href="Register.aspx">Register</a>
            </form>
        </div>
    </div>

    <!-- Mainly scripts -->
    <script src="js/jquery-3.1.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>

</body>

</html>

