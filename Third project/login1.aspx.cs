using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            Tips.Text = "";
        }
    }
    protected void login_win_Authenticate(object sender, AuthenticateEventArgs e)
    {

    }
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)//登录
    {
        if (password.Text == "")
        {
            Tips.Text = "密码不能为空";
        }
        else if (account.Text == "")
        {
            Tips.Text = "账号不能为空";
        }
        else
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
                Response.Write("<script>alert('登录成功');window.window.location.href='home.aspx';</script> ");
            }
            else
                Tips.Text = "密码错误或此账户不存在";
        }
    }
    protected void regist_Click(object sender, EventArgs e)
    {
        Response.Redirect("regist.aspx");
    }
}