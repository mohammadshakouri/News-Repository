<%@ Page Title="خانه" Language="C#" MasterPageFile="~/Pages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="News.App.Pages.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="row justify-content-center">
        <div class="col-auto">
            <h3 style="font-size: 2rem;">سایت خبری روز از نو روزی از نو به روز ترین <mark class="rounded-3">خبرهای جهان</mark></h3>
        </div>
    </div>
    <br />
    
    <div class="row table-responsive rounded">
        <table class="table table-sm table-hover table-bordered text-center align-middle rounded">
            <thead>
                <tr class="table-light">
                    <th>ردیف</th>
                    <th>نوع خبر</th>
                    <th>عنوان خبر</th>
                    <th>خلاصه خبر</th>
                    <th></th>

                </tr>
            </thead>
            <tbody id="tbody" runat="server">
                <%  GetNews();   %>
            </tbody>

        </table>
    </div>

</asp:Content>
