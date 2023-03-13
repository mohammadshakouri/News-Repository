<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="News.App.Pages.SignUpPage" %>

<!DOCTYPE html>

<html dir="rtl" lang="fa">
<head runat="server">
    <title>ثبت نام</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css">    <link href="../Content/Css/StyleSheet.css" rel="stylesheet" />
    <link href="../Content/Webfonts/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap-5.2.0-dist/css/bootstrap.rtl.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <div class="container-fluid">
            <br />
            <div class="row justify-content-center">

                <div class="col-md-auto col-sm-4">
                    <label for="FullName" class="form-label">نام  و نام خانوادگی</label>
                    <input type="text" id="FullName" runat="server" class="form-control" maxlength="30" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger" runat="server" ControlToValidate="FullName" ErrorMessage="نام و نام خانوادگی باید وارد شود" ValidationGroup="signup"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-auto col-sm-4">

                    <label for="Email" class="form-label">ایمیل</label>
                    <input type="email" id="Email" runat="server" class="form-control" maxlength="30" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger" runat="server" ControlToValidate="Email" ErrorMessage="ایمیل باید وارد شود" ValidationGroup="signup"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-auto col-sm-4">
                    <label for="Phone" class="form-label">شماره موبایل</label>
                    <input type="tel" id="Phone" runat="server" class="form-control" maxlength="11" placeholder="09120000000" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-danger" runat="server" ControlToValidate="Phone" ErrorMessage="تلفن همراه باید وارد شود" ValidationGroup="signup"></asp:RequiredFieldValidator>
                </div>

            </div>
            <br />
            <div class="row justify-content-center">

                <div class="col-md-auto col-sm-4">
                    <label for="Username" class="form-label">نام کاربری</label>
                    <input type="text" id="Username" runat="server" class="form-control" maxlength="16" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-danger" runat="server" ControlToValidate="Username" ErrorMessage="نام کاربری باید وارد شود" ValidationGroup="signup"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-auto col-sm-4">
                    <label for="Password" class="form-label">رمز عبور</label>
                    <input type="password" id="Password" runat="server" class="form-control" maxlength="20" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="text-danger" runat="server" ControlToValidate="Password" ErrorMessage="رمز عبور باید وارد شود" ValidationGroup="signup"></asp:RequiredFieldValidator>
                </div>
                <div class="col-md-auto col-sm-4">
                    <label for="ConfirmPassword" class="form-label">تکرار رمز عبور</label>
                    <input type="password" id="ConfirmPassword" runat="server" class="form-control" maxlength="20" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="text-danger" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="تکراررمز عبور را وارد کنید" ValidationGroup="signup"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" CssClass="text-danger" ControlToValidate="ConfirmPassword" ControlToCompare="Password" runat="server" ErrorMessage="تکرار رمز عبور مطابقت ندارد" ValidationGroup="signup"></asp:CompareValidator>
                </div>
            </div>
            <br />
            <div class="row justify-content-center text-center">

                <div class="col-auto">
                    <asp:Button ID="BTnSignUp" class="btn btn-success" Text="ثبت نام" runat="server" OnClick="BTnSignUp_Click" ValidationGroup="signup" />
                </div>

            </div>

            <br />
        </div>
    </form>
</body>
</html>
