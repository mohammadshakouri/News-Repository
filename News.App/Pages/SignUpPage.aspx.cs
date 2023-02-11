using System;
using System.Collections.Generic;
using System.Linq;
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
                useridentity.InnerHtml = HttpContext.Current.User.Identity.Name;
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

        

    }
}
