<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Davin_Laurings_PROG7311_POE_ST10067956.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <!-- Same styling as the main Master -->
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <link href="~/Content/Styles.css" rel="stylesheet" />

    <style>

        .wrapper1
        {
            height:90vh !important;
            display:flex;
            align-items:center;
            flex-direction:column;
            justify-content:center;
            width:100% !important;
            padding:20px;
            background-color:#f5f5f5 !important;
        }

        .logincontainer
        {
            border-radius:0px;
            background-color:#fff;
            width:90%;
            max-width:450px;
            position:relative;
            padding:20px;
            border:1px white solid;
            box-shadow:0 15px 10px -10px #acacac;
        }

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" runat="server" href="~/">Aggri-Energy Connect</a>
            </div>
        </nav>
            <div class="wrapper1">
                <div class="logincontainer">
                    <h3 class="card-title" >Login</h3>
                    <p/>
                    <asp:Label ID="lblErrorMessage" runat="server" CssClass="text-danger">Username or Password was incorrect</asp:Label>
                    <div class="form-group">
                        <label for="txtUsername">Username:</label>
                        <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter your username" CssClass="form-control"/>
                    </div>
                    <p/>
                    <div class="form-group">
                        <label for="txtPassword">Password:</label>
                        <asp:TextBox runat="server" ID="txtPassword" placeholder="Enter your password" CssClass="form-control" TextMode="Password"/>
                    </div>
                    <p/>
                    <div class="form-group">
                        <asp:Button ID="btnLogin" class="btn btn-primary" onclick="btnLogin_OnClick" runat="server" Text="Login"/>
                    </div>
                 </div>
            </div>
    </form>
</body>
</html>
