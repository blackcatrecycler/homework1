using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class article : System.Web.UI.Page
{
    int n = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] != null)
        {
            //string select1 = "SELECT name1 FROM users WHERE ID =" + Session["id"];
            //DataSet ds1 = admin.DataS(select1);
            //name.Text = ds1.Tables[0].Rows[0][0].ToString() + "  欢迎你！";
            using (var db = new blogEntities())
            {
                int id2 = Convert.ToInt32(Session["id"].ToString());
                name.Text = db.users.SingleOrDefault(a => a.ID == id2).name1 + "欢迎你！";
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
        string id = Request.QueryString["ID"];
        string select = "SELECT * FROM blog WHERE ID=" + id + "";
        DataSet ds = God_admin.admin.DataS(select);
        Title.Text = ds.Tables[0].Rows[0][1].ToString();
        Describe.Text = ds.Tables[0].Rows[0][2].ToString();
        Body.Text = ds.Tables[0].Rows[0][3].ToString();
        try
        {
            if (Session["id"].ToString() != ds.Tables[0].Rows[0][4].ToString()) update.Visible = false;
        }
        catch { update.Visible = false; }
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT *FROM blog_c WHERE articleID =" + id + " ORDER BY time").DefaultView;
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
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)    //登陆注销
    {
        if (login1.Text == "登录")
        {
            if (account.Text != "" && password.Text != "")
            {
                int result;
                try
                {
                    result = 1;
                    string select = "SELECT *FROM users WHERE account ='" + account.Text + "'AND password ='" + password.Text + "'";
                    DataSet ds = admin.DataS(select);
                    Session["id"] = ds.Tables[0].Rows[0][0].ToString();
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
    protected void enter1_Click(object sender, EventArgs e)
    {
        Response.Redirect("editor.aspx");
    }
    protected void register_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
    protected void Body_DataBinding(object sender, EventArgs e)
    {
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        if (Session["id"] != null)
        {
            string id = Request.QueryString["ID"];
            DateTime dt = DateTime.Now;
            string select = "INSERT INTO comments (articleID,accountID,time,text) VALUES(" + id + "," + Session["id"] + ",'" + dt.ToString() + "',N'"+admin.TextC(TextBox1.Text)+"')";
            int result = admin.In(select);
            if (result == 1)
            {
                Response.Write("<script>alert('评论成功')</script>");
            }
            else 
            {
                Response.Write("<script>alert('评论失败')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('您没有登录，请先登录');window.window.location.href='login1.aspx';</script> ");
        }     　
    }
    protected void update_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        Response.Redirect("article2.aspx?id=" + id + "");
    }
    protected void first_page_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT *FROM blog_c WHERE articleID =" + id + " ORDER BY time").DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 3;
        pds.CurrentPageIndex = 0;
        now1.Text = "1";
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }
    protected void final_page_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT *FROM blog_c WHERE articleID =" + id + " ORDER BY time").DefaultView;
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
        string id = Request.QueryString["id"];
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT *FROM blog_c WHERE articleID =" + id + " ORDER BY time").DefaultView;
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
        string id = Request.QueryString["id"];
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT *FROM blog_c WHERE articleID =" + id + " ORDER BY time").DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 3;
        int m;
        for (m = 0; pds.IsLastPage != true; m++)
        {
            pds.CurrentPageIndex = m;
        }
        if (n + 1 != m && m != 0)
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
}