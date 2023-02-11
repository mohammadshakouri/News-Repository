using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News.App.Pages
{
    public partial class Action : System.Web.UI.Page
    {
        Models.NewsDBEntities db = new Models.NewsDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            FillCombo();
            if (Request.QueryString["newsid"] != null)
            {
                if (Request.QueryString["newsid"] == "0")
                {
                    Btndelete.Visible = false;
                    BtnSave.Text = "افزودن خبر";                   

                }
                else
                {
                    if (!IsPostBack)
                    {
                        int NewsId = int.Parse(Request.QueryString["newsid"]);
                        var news = db.News.Find(NewsId);
                        TxtTitle.Value = news.NewsTitle;
                        Txtsummary.Value = news.NewsSummary;
                        NewsTypeSelect.Value = news.NewsTypeID.ToString();
                    }
                }
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.Text == "افزودن خبر")
            {
                Models.News mynews = new Models.News();
                mynews.NewsTitle = TxtTitle.Value;
                mynews.NewsSummary = Txtsummary.Value;
                mynews.NewsTypeID = int.Parse(NewsTypeSelect.Value);
                db.News.Add(mynews);
                db.SaveChanges();
                Response.Redirect("Default.aspx");
            }
            else
            {
                int NewsId = int.Parse(Request.QueryString["newsid"]);
                var news = db.News.Find(NewsId);
                news.NewsTitle = TxtTitle.Value;
                news.NewsSummary = Txtsummary.Value;
                news.NewsTypeID = int.Parse(NewsTypeSelect.Value);
                db.SaveChanges();
                Response.Redirect("Default.aspx");
            }


        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["newsid"] != null && Request.QueryString["newsid"] != "0")
            {
                int NewsId = int.Parse(Request.QueryString["newsid"]);
                var news = db.News.Find(NewsId);
                db.News.Remove(news);
                db.SaveChanges();
                Response.Redirect("Default.aspx");

            }



        }
        
        protected void FillCombo()
        {
            StringBuilder str = new StringBuilder();
            using (var db = new Models.NewsDBEntities())
            {              
                var newstypes = db.NewsType.ToList();
                foreach (var item in newstypes)
                {
                    //NewsTypeSelect.Items.Add(new ListItem
                    //{
                    //    Text = item.NewsTypeTitle,
                    //    Value = item.NewsTypeID.ToString()
                    //}
                    //);
                    NewsTypeSelect.Items.Add(new ListItem(item.NewsTypeTitle, item.NewsTypeID.ToString()));
                }
            }

        }
    }
}