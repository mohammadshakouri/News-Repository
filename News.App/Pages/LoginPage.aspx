<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="News.App.Pages.LoginPage" %>

<!DOCTYPE html>

<html dir="rtl" lang="fa">
<head runat="server">
    <title>ورود به سایت</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../Content/Css/StyleSheet.css" rel="stylesheet" />
    <link href="../Content/Webfonts/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap-5.2.0-dist/css/bootstrap.rtl.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div class="col-auto">
                    <label for="username">نام کاربری:</label>
                    <input type="text" class="form-control" id="username" runat="server" name="username" maxlength="20" />
                    <label for="password">رمز عبور:</label>
                    <input type="password" class="form-control" id="password" runat="server" name="password" maxlength="20" />
                </div>                
                </div>
                <br />
                <div class="row justify-content-center text-center">                    
                    <div class="col-auto">
                        <br />
                        <asp:Button ID="BtnSignIn" runat="server" class="btn btn-outline-success" Text="ورود به سامانه" OnClick="BtnSignIn_Click" />
                        <asp:Button ID="BTnSignUp" runat="server" class="btn btn-success" Text="ثبت نام" OnClick="BtnSignUp_Click" /> <hr />
                        <p id="danger" runat="server"></p></div>
                    </div>
            <br />
            <div class="col-12">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server"></asp:UpdateProgress>
            </div>
                </div>
                <br />                         
        
    </form>
    <script src="../Content/bootstrap-5.2.0-dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
