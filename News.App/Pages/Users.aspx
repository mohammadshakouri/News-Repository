<%@ Page Title="کاربران" Language="C#" MasterPageFile="~/Pages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="News.App.Pages.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <table class="table table-sm table-hover table-bordered text-center align-middle">
        <thead>
            <tr class="table-light">
                <th>ردیف</th>
                <th>نام کاربری</th>
                <th>نام کامل</th>
                <th>تلفن</th>
                <th>ایمیل</th>
                <th></th>
            </tr>
        </thead>
        <tbody id="tbody" runat="server">
            <% GetUserList(); %>
        </tbody>

    </table>

</asp:Content>
