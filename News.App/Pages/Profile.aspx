<%@ Page Title="حساب کاربری" Language="C#" MasterPageFile="~/Pages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="News.App.Pages.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    
    <div class="row">
        <br />
        <br />
        <br />
        <div class="col-lg-2"></div>
        <div class="col-md-4 col-lg-3">
            <label for="FullName">نام  و نام خانوادگی</label>
            <input type="text" id="FullName" runat="server" class="form-control" disabled />
            <br />
        </div>
        <div class="col-md-4 col-lg-3">
            <label for="Email">ایمیل</label>
            <input type="email" id="Email" runat="server" class="form-control" disabled />
            <br />
        </div>
        <div class="col-md-4 col-lg-3">
            <label for="Phone">شماره موبایل</label>
            <input type="tel" id="Phone" runat="server" class="form-control" disabled />
        </div>
        <div class="col-lg-1"></div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-2"></div>
        <div class="col-md-4 col-lg-3">
            <label for="Username">نام کاربری</label>
            <input type="text" id="Username" runat="server" class="form-control" disabled />
            <br />
        </div>
        <div class="col-md-4 col-lg-3">
            <br />
            <asp:Button ID="BtnDelete" runat="server" CssClass="btn btn-danger" Text="حذف کاربر" OnClick="BtnDelete_Click" />
            <asp:Button ID="BtnReturn" runat="server" CssClass="btn btn-info" Text="بازگشت" OnClick="BtnReturn_Click" />
        </div>
        
    </div>
    <br />
</asp:Content>
