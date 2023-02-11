﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News.App.Pages
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUserIsAuthenticated();
        }

        private void CheckUserIsAuthenticated()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                useridentity.InnerHtml = HttpContext.Current.User.Identity.Name;

            }
            else
            {
                BtnSignOut.Visible = false;
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void BtnSignOut_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            BtnSignOut.Visible = false;

        }

        protected void AdminMenuItemsCreator()
        {
            using (Models.NewsDBEntities db = new Models.NewsDBEntities())
            {
                if (db.Users.Where(u => u.FullName == HttpContext.Current.User.Identity.Name.ToString()).Any())
                {
                    var currentuser = db.Users.Where(u => u.FullName == HttpContext.Current.User.Identity.Name.ToString()).FirstOrDefault();
                    if (currentuser.Roles.RoleName == "Admin")
                    {
                        var str = new StringBuilder();
                        str.Append("<li class=\"nav-item\">\r\n <a class=\"nav-link\" href=\"Action.aspx?newsid=0\"><i class=\"bi-plus-circle-fill\" style=\"margin-left:5px; font-size:1.25rem;\"></i>افزودن خبر</a>\r\n </li>\r\n \r\n" +
                            "<li class=\"nav-item\">\r\n<a class=\"nav-link\" href=\"Users.aspx\"><i class=\"bi-people-fill\" style=\"margin-left:5px; font-size:1.25rem;\"></i>کاربران</a>\r\n</li>\r\n" +
                            "<li class=\"nav-item\">\r\n<a class=\"nav-link\" href=\"SignUpPage.aspx?loginstatus=success\"><i class=\"bi-person-plus-fill\" style=\"margin-left:5px; font-size:1.25rem;\"></i>ثبت نام کاربر</a>\r\n</li>");
                        Response.Write(str);
                    }
                }

            }
        }

    }
}