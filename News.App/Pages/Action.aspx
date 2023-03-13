<%@ Page Title="Action" Language="C#" MasterPageFile="~/Pages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Action.aspx.cs" Inherits="News.App.Pages.Action" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
       <div class="row">
        
        <div class="col-lg-3 col-md-4">
            <label for="TxtTitle">عنوان خبر</label>
            <br />
            <input type="text" required="required" class="form-control" id="TxtTitle" runat="server" name="TxtTitle" />
        </div>
        
        
    </div>
    <br />
    <div class="row">
        <div class="col-lg-3 col-md-4" >
            <label for="NewsTypeSelect">نوع خبر</label>
                <select id="NewsTypeSelect" runat="server" class="form-select">


                    </select>
            
        </div>
        <br />
    </div>
   <br />
     <div class="row">
         <div class="col-lg-4 col-md-6">
            <label for="Txtsummary">محتوای خبر</label>
            <br />
             <textarea class="form-control" id="Txtsummary" runat="server" style="height:200px;"></textarea>           
        </div>  
     </div>
     <br />
    <div class="row">
        <div class="col-md-4 col-lg-3">
            <asp:Button ID="BtnSave" runat="server" CssClass="btn btn-success" Text=" ذخیره خبر" OnClick="BtnSave_Click" />
            <asp:Button ID="Btndelete" runat="server" CssClass="btn btn-danger" Text="حذف خبر" OnClick="Btndelete_Click" />
        </div>
    </div>



   

</asp:Content>
