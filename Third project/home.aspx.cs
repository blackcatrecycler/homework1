using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using God_admin;

public partial class home : System.Web.UI.Page
{
    static int n=0;
    protected void Page_Load(object sender, EventArgs e)
    {
            if (Session["id"] != null)
            {
                //string select = "SELECT name1 FROM users WHERE ID =" + Session["id"];
                //DataSet ds = admin.DataS(select);
                //name.Text = ds.Tables[0].Rows[0][0].ToString() + "  欢迎你！";
                using (var db = new blogEntities())
                {
                    int id2 = Convert.ToInt32(Session["id"].ToString());
                    name.Text = db.users.SingleOrDefault(a=>a.ID==id2).name1 + "欢迎你！";
                }
                login1.Text = "注销";
                name.Visible = true;
                enter1.Visible = true;
            }
            else
            {                
                login1.Text = "登录";
                Label1.Visible = true;
                Label2.Visible = true;
                account.Visible = true;
                password.Visible = true;
                register.Visible = true;
            }
         PagedDataSource pds = new PagedDataSource();
         using (var db = new blogEntities())
         {
             pds.DataSource = (from it in db.blog_user
                               orderby  it.time descending
                               select it).ToList();
             
         }
         pds.AllowPaging = true;
         pds.PageSize = 3;
         if (!Page.IsPostBack)
         {
             Repeater1.DataSource = pds;
             Repeater1.DataBind();
             now1.Text = "1";
         }
         n = Convert.ToInt32(now1.Text) - 1;
    }


    protected void enter1_Click(object sender, EventArgs e)
    {
        Response.Redirect("editor.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)//登陆/注销
    {
        if (login1.Text == "登录")
        {
            if (account.Text != "" && password.Text != "")
            {
                int result;
                try
                {
                    result = 1;
                    //string select = "SELECT *FROM users WHERE account ='" + account.Text + "'AND password ='" + password.Text + "'";
                    //DataSet ds = admin.DataS(select);
                    //Session["id"] = ds.Tables[0].Rows[0][0].ToString();
                    using (var db = new blogEntities())
                    {
                        Session["id"] = db.users.SingleOrDefault(it => it.account == account.Text && it.password == password.Text).ID.ToString();
                    }
                }
                catch { result = 0; }
                if (result == 1)
                {
                    Response.Redirect("home.aspx");
                }
                else
                    Response.Write("<script>alert('用户名或密码错误');window.window.location.href='login1.aspx';</script> ");
            }
            else
            {
                Response.Redirect("login1.aspx");
            }
        }
        else 
        {
            Session["id"] = null;
            Response.Redirect(Request.Url.ToString());
        }
    }
    protected void first_page_Click(object sender, EventArgs e)
    {
        PagedDataSource pds = new PagedDataSource();
        using (var db = new blogEntities())
        {
            pds.DataSource = (from it in db.blog_user
                              orderby it.time descending
                              select it).ToList();

        }
        pds.AllowPaging = true;
        pds.PageSize = 3;
        pds.CurrentPageIndex = 0;
        now1.Text = "1";
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
    protected void final_page_Click(object sender, EventArgs e)
    {
        PagedDataSource pds = new PagedDataSource();
        using (var db = new blogEntities())
        {
            pds.DataSource = (from it in db.blog_user
                              orderby it.time descending
                              select it).ToList();

        }
        pds.AllowPaging = true;
        pds.PageSize = 3;
        for (n = 0; pds.IsLastPage != true; n++)
        {
            pds.CurrentPageIndex = n;
        }
        if (n == 0)
        { n = 1; }
        now1.Text = n.ToString();
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
    protected void last_page_Click(object sender, EventArgs e)          //上一页
    {
        PagedDataSource pds = new PagedDataSource();
        using (var db = new blogEntities())
        {
            pds.DataSource = (from it in db.blog_user
                              orderby it.time descending
                              select it).ToList();

        }
        pds.AllowPaging = true;
        pds.PageSize = 3;
        if (n != 0)
        { 
            --n;
            pds.CurrentPageIndex = n;
            ++n;
            now1.Text = n.ToString();
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }
        else Response.Write("<script>alert('这已经是第一页了')</script>");
    }   
    protected void next_page_Click(object sender, EventArgs e)      //下一页
    {

        PagedDataSource pds = new PagedDataSource();
        using (var db = new blogEntities())
        {
            pds.DataSource = (from it in db.blog_user
                              orderby it.time descending
                              select it).ToList();

        }
        pds.AllowPaging = true;
        pds.PageSize = 3;
        int m;
        for (m = 0; pds.IsLastPage != true; m++)
        {
            pds.CurrentPageIndex = m;
        }
        if (n+1!= m && m!=0)
        {
            ++n;
            pds.CurrentPageIndex = n;
            ++n;
            now1.Text = n.ToString();
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
        }
        else Response.Write("<script>alert('这已经是最后一页了')</script>");
    }
    protected void register_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
    protected void Rallpicture_Click(object sender, EventArgs e)
    {
        Response.Redirect("allpicture.aspx");
    }
}