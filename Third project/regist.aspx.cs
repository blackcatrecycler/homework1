using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class regist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Tips.Text = "";
        }
    }
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void sure1_Click(object sender, EventArgs e)
    {
        if (account.Text == "")
        {
            Tips.Text = "用户名不能为空";
        }
        else if (account.Text.Length < 6)
        {
            Tips.Text = "用户名长度不能小于6";
        }
        else if (account.Text.Length > 16)
        {
            Tips.Text = "用户名长度不能大于16";
        }
        else if (password1.Text.Length < 4)
        {
            Tips.Text = "密码长度不能小于4";
        }
        else if (password1.Text.Length > 16)
        {
            Tips.Text = "密码长度不能大于16";
        }
        else if (password1.Text != password2.Text)
        {
            Tips.Text = "前后密码不一致";
        }
        else if (name.Text == "")
        {
            Tips.Text = "姓名不能为空";
        }
        else
        {
            int result;
            string select = "SELECT *FROM users WHERE account = '" + account.Text + "'";
            DataSet ds = admin.DataS(select);
            result = ds.Tables[0].Rows.Count;
            if (result == 0)
            {
                select = "INSERT INTO users (account,password,name1) VALUES('" + account.Text + "','" + password1.Text + "',N'" + name.Text + "')";
                result = admin.In(select);
                if (result == 1)
                {
                    select = "SELECT *FROM users WHERE account ='" + account.Text + "'";
                    ds = admin.DataS(select);
                    string ID = ds.Tables[0].Rows[0][0].ToString();
                    Session["id"] = ID;
                    Response.Write("<script>alert('注册成功');window.window.location.href='home.aspx';</script> ");
                }
                else
                {
                    Tips.Text = "请检查用户名或密码中是否出现非法字符";
                }
            }
            else
            {
                Tips.Text = "此账号已被人使用，请更换账号";
            }
        }
    } 
}