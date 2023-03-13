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


    }
}
