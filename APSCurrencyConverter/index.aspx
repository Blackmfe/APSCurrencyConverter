<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="APSCurrencyConverter.index" %>

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
            <h3>Currency Converntion System</h3>
            <asp:Label ID="lblerror" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
            <form class="m-t" runat="server">
                <div class="form-group">
                    <asp:TextBox type="number" ID="txtInput" runat="server" class="form-control" placeholder="Enter Number" required=""></asp:TextBox>
                </div>
                <div class="form-group">
                        <asp:DropDownList ID="drpFromCurrency" runat="server" class="form-control" required="">
                            <asp:ListItem Text="Rand" Value="ZAR"></asp:ListItem>
                            <asp:ListItem Text="Pound" Value="LB"></asp:ListItem>
                            <asp:ListItem Text="Dollar" Value="USD"></asp:ListItem>
                        </asp:DropDownList>
                </div>
                <div class="form-group">
                        <asp:DropDownList ID="drpToCurrency" runat="server" class="form-control" required="">
                            <asp:ListItem Text="Dollar" Value="USD"></asp:ListItem>
                            <asp:ListItem Text="Pound" Value="LB"></asp:ListItem>
                            <asp:ListItem Text="Rand" Value="ZAR"></asp:ListItem>
                        </asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:TextBox type="text" ID="txtOutput" runat="server" class="form-control" placeholder="" ReadOnly="true" ></asp:TextBox>
                </div>
                <asp:Button ID="btnConvert" runat="server" Text="Convert" class="btn btn-primary block full-width m-b" OnClick="btnConvert_Click"/>
            </form>
        </div>
    </div>

    <!-- Mainly scripts -->
    <script src="js/jquery-3.1.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>

</body>

</html>
