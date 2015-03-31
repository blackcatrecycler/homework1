using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editor : System.Web.UI.Page
{
    int n = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        string select = "SELECT name1 FROM users WHERE ID =" + Session["id"];
        DataSet ds = God_admin.admin.DataS(select);
        name.Text = ds.Tables[0].Rows[0][0].ToString() + "  欢迎你！";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT * FROM blog_user WHERE StudentID=" + Session["id"] + " ORDER BY time DESC").DefaultView;
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

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session["id"] = null;
        Response.Redirect("home.aspx");
    }
    protected void enter2_Click(object sender, EventArgs e)
    {
        Response.Redirect("article2.aspx");
    }
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void EandD(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString();
        if (e.CommandName == "editor")
        {
            Response.Redirect("article2.aspx?id=" + id + "");
        }
        if (e.CommandName == "delete")
        {
            string select = "DELETE FROM blog WHERE ID=" + id + "";
            int result = admin.In(select);
            if (result == 1)
            {
                Response.Write("<script>alert('删除成功')</script>");
                Response.Redirect(Request.Url.ToString());
            }
            else 
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
    protected void first_page_Click(object sender, EventArgs e)
    {
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = admin.DataT("SELECT * FROM blog_user WHERE StudentID=" + Session["id"] + " ORDER BY time DESC").DefaultView;
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
        pds.DataSource = admin.DataT("SELECT * FROM blog_user WHERE StudentID=" + Session["id"] + " ORDER BY time DESC").DefaultView;
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
        pds.DataSource = admin.DataT("SELECT * FROM blog_user WHERE StudentID=" + Session["id"] + " ORDER BY time DESC").DefaultView;
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
        pds.DataSource = admin.DataT("SELECT * FROM blog_user WHERE StudentID=" + Session["id"] + " ORDER BY time DESC").DefaultView;
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