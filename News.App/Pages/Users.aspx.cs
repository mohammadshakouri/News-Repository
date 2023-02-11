using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace News.App.Pages
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetUsers(); I put this method in the UI page
        }
        public void GetUsers()
        {
            StringBuilder str = new StringBuilder();
            Models.NewsDBEntities db = new Models.NewsDBEntities();
            int count = 0;
            var query = db.Users.Select(user => user);
    
            foreach (var n in query)
            {
                count++;
                str.Append("<tr><td>" + count + "</td>");
                str.Append("<td>" + n.Username + "</td>");
                str.Append("<td>" + n.FullName + "</td>");
                str.Append("<td>" + n.Phone + "</td>");
                str.Append("<td>" + n.Email + "</td>");
                str.Append($"<td><a class=\"btn btn-info\" href=\"profile.aspx?userid={n.UserID}\">مشاهده</a></td></tr>");
                
            }
            //tbody.Controls.Add(new Literal { Text = str.ToString() });
            Response.Write(str);
        }
    }
}
