using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News.App.Pages
{
    public partial class profile : System.Web.UI.Page
    {
        Models.NewsDBEntities db = new Models.NewsDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            GetUserInfo();
        }
        public void GetUserInfo()
        {
           
            if (Request.QueryString["userid"]==null)
            {
                if (!User.Identity.IsAuthenticated)
                    Response.Redirect("loginpage.aspx",true);

                BtnDelete.Visible = false;
                
                var user = db.Users.Where(u => u.FullName == User.Identity.Name).FirstOrDefault();
                FullName.Value = user.FullName;
                Email.Value = user.Email;
                Phone.Value = user.Phone;
                Username.Value = user.Username;                
            }
            else
            {
                var CurrentUser = db.Users.Where(u => u.FullName == User.Identity.Name).First();
                int userid = int.Parse(Request.QueryString["userid"]);
                if(userid==CurrentUser.UserID)
                {
                    BtnReturn.Text = "کاربر جاری - بازگشت";
                    BtnDelete.Visible = false;
                }
                var user = db.Users.Find(userid);
                FullName.Value = user.FullName;
                Email.Value = user.Email;
                Phone.Value = user.Phone;
                Username.Value = user.Username;                
            }
            
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(Request.QueryString["userid"]);
            var user = db.Users.Find(userid);
            db.Users.Remove(user);
            db.SaveChanges();
            Response.Redirect("Users.aspx");
        }

        protected void BtnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users.aspx");
        }
    }
}