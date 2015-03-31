using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class allpicture : System.Web.UI.Page
{
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
        using (var db = new blogEntities())
        {
            Repeater1.DataSource = (from it in db.picture_u
                                    orderby it.time descending
                                     select it).ToList();
        }
        Repeater1.DataBind();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
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
    protected void register_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
    protected void enter1_Click(object sender, EventArgs e)
    {
        Response.Redirect("picture.aspx");
    }
    protected void Rhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}