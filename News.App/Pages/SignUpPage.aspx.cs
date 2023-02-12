using News.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News.App.Pages
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        Models.NewsDBEntities db = new Models.NewsDBEntities();
        Models.Users newuser = new Models.Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["loginstatus"] != "success")
            {
                header.Visible = false;

            }
            else
            {
                ForbidNonAdminUsers();
                string role = GetUserRole();
                useridentity.InnerHtml = $"<i class=\"bi-file-person-fill\" style=\"margin-left:5px; font-size:1.25rem; vertical-align: middle;\"></i>{HttpContext.Current.User.Identity.Name} ({role})";
                header.Visible = true;

            }

        }

        protected void BTnSignUp_Click(object sender, EventArgs e)
        {

            newuser.Email = Email.Value;
            newuser.FullName = FullName.Value;
            newuser.Phone = Phone.Value;
            newuser.Username = Username.Value;
            newuser.Password = Password.Value.TOHash();
            newuser.RoleID = byte.Parse("2");
            db.Users.Add(newuser);
            db.SaveChanges();
            if (Request.QueryString["loginstatus"] == "success")
                Response.Redirect("users.aspx");
            else
                Response.Redirect("LoginPage.aspx?signupcondition=success");
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
        protected string GetUserRole()
        {
            string UserRole = "";
            using (var db = new NewsDBEntities())
            {
                var user = db.Users.Where(u => u.FullName == HttpContext.Current.User.Identity.Name).FirstOrDefault();
                var userroleFromDB = user.Roles.RoleName.ToString();

                switch (userroleFromDB)
                {
                    case "Admin": UserRole = "مدیر کل سیستم"; break;
                    case "Author": UserRole = "نویسنده خبر"; break;
                    case "Editor": UserRole = "ویرایشگر"; break;
                    case "Member": UserRole = "کاربر"; break;
                }
            }
            return UserRole;
        }
        protected void ForbidNonAdminUsers()
        {
            string UserRoleInDb = "";
            using (var db = new NewsDBEntities())
            {
                var user = db.Users.Where(u => u.FullName == HttpContext.Current.User.Identity.Name).FirstOrDefault();
                UserRoleInDb = user.Roles.RoleName.ToString();

            }

            if (UserRoleInDb != "Admin")
            {
                System.Web.Security.FormsAuthentication.SignOut();
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            }

        }
    }
}
