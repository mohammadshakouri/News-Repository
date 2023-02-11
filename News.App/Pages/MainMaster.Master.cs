using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}