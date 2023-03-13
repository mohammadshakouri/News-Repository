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

            }
            else
            {
                string role = GetUserRole();
                useridentity.InnerHtml = $"<i class=\"bi-file-person-fill\" style=\"margin-left:5px; font-size:1.25rem; vertical-align: middle;\"></i>{HttpContext.Current.User.Identity.Name} ({role})";
                header.Visible = true;

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
            Response.Redirect("LoginPage.aspx?signupcondition=success");
        }

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

            }

            if (UserRoleInDb != "Admin")
            {
                System.Web.Security.FormsAuthentication.SignOut();
                System.Web.Security.FormsAuthentication.RedirectToLoginPage();
            }

        }
    }
}
