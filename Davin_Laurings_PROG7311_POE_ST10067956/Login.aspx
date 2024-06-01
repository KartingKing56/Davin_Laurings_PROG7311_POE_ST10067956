<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Davin_Laurings_PROG7311_POE_ST10067956.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <!-- Same styling as the main Master -->
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <link href="~/Content/Styles.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" runat="server" href="~/">Aggri-Energy Connect</a>
            </div>
        </nav>
        <main class="container mt-4">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title" >Login</h4>
                            <asp:Label ID="lblErrorMessage" runat="server" CssClass="text-danger" Visible="false"></asp:Label>
                            <div class="form-group">
                                <label for="txtUsername">Username:</label>
                                <input type="text" id="txtUsername" class="form-control" runat="server" placeholder="Enter your username" />
                            </div>
                            <p/>
                            <div class="form-group">
                                <label for="txtPassword">Password:</label>
                                <input type="password" id="txtPassword" class="form-control" runat="server" placeholder="Enter your password" />
                            </div>
                            <p/>
                            <div class="form-group">
                            <button id="btnLogin" class="btn btn-primary" onclick="btnLogin_OnClick" runat="server">Login</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
    </form>
</body>
</html>
