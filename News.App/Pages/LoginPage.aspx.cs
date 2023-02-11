using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace News.App.Pages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Request.QueryString["signupcondition"] == "success")
            {
                danger.Attributes.Add("class", "alert alert-success alert-dismissible fade show");
                danger.InnerHtml = "ثبت نام شما با <strong>موفقیت</strong> انجام شد.";
            }
        }

        protected void BtnSignIn_Click(object sender, EventArgs e)
        {
            Models.NewsDBEntities db = new Models.NewsDBEntities();
            var IsUserExsist = db.Users.Where(u => u.Username == username.Value).Any();
            if (IsUserExsist)
            {
                var user = db.Users.Where(u => u.Username == username.Value).FirstOrDefault();
                if (password.Value.TOHash() == user.Password)
                {
                    
                        danger.Attributes.Add("class", "alert alert-success alert-dismissible fade show");
                        danger.InnerHtml = "با <strong>موفقیت</strong> وارد شدید";                                   
                        System.Web.Security.FormsAuthentication.RedirectFromLoginPage(user.FullName, true);
                }
                else
                {

                    danger.Attributes.Add("class", "alert alert-danger");
                    danger.InnerText = "نام کاربری یا رمز عبور اشتباه است!";

                }
            }
            else
            {

                danger.Attributes.Add("class", "alert alert-danger");
                danger.InnerHtml = "کاربر مورد نظر یافت نشد!";
            }

        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpPage.aspx");
        }

    }
}