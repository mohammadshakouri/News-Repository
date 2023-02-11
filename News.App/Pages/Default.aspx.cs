using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News.App.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                     
            //GetNews();    
        }
        
        protected void GetNews()
        {
            var str = new StringBuilder();
            using (var db = new Models.NewsDBEntities())
            {
                int count = 0;
                var query =
        from News in db.News
        join Newstype in db.NewsType on News.NewsTypeID equals Newstype.NewsTypeID
        select new { News.NewsTitle, News.NewsSummary, News.NewsID, Newstype.NewsTypeTitle };
                foreach (var n in query)
                {
                    count++;
                    str.Append("<tr><td>" + count + "</td>");
                    str.Append("<td>" + n.NewsTypeTitle + "</td>");
                    str.Append("<td>" + n.NewsTitle + "</td>");
                    str.Append("<td>" + n.NewsSummary + "</td>");
                    str.Append($"<td><a class=\"btn btn-info\" href=\"Action.aspx?newsid={n.NewsID}\">ویرایش</a></td></tr>");

                }
            }
                       
            //tbody.Controls.Add(new Literal { Text = str.ToString() });
            Response.Write(str);
        }
    }
}