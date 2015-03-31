using God_admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class article2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                string id = Request.QueryString["ID"];
                string select = "SELECT * FROM blog WHERE ID=" + id + "";
                DataSet ds = God_admin.admin.DataS(select);
                Title.Text = ds.Tables[0].Rows[0][1].ToString();
                Describe.Text = ds.Tables[0].Rows[0][2].ToString();
                Body.Text = ds.Tables[0].Rows[0][3].ToString();
                SureButton.Text = "保存";
            }
            catch
            {
                SureButton.Text = "发表";
            }
        }
    }
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("editor.aspx");
    }
    protected void SureButton_Click(object sender, EventArgs e)
    {
        if (Title.Text != "" && Body.Text != "" && Title.Text.Length <= 50 && Describe.Text.Length <= 50)
        {
            if (Describe.Text == "")
            {
                if (Body.Text.Length > 20)
                {
                    Describe.Text = Body.Text.Substring(0, 20);
                }
                else
                {
                    Describe.Text = Body.Text;
                }
            }
            if (SureButton.Text == "保存")
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                string select = "UPDATE blog SET title = N'" + Title.Text + "', time = '" + dt.ToString() + "',describe = N'" + Describe.Text + "', text = N'" + God_admin.admin.TextC(Body.Text) + "'WHERE ID = " + Request.QueryString["ID"] + "";
                int result = God_admin.admin.In(select);
                if (result == 1)
                {
                    Response.Write("<script>alert('保存成功');window.window.location.href='editor.aspx';</script> ");
                }
                else
                {
                    Response.Write("<script>alert('保存失败')</script>");
                }
            }
            else
            {
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                //string select = "INSERT INTO blog (title,describe,text,StudentID,time) VALUES(N'" + Title.Text + "',N'" + Describe.Text + "',N'" + God_admin.admin.TextC(Body.Text) + "'," + Session["ID"] + ",'" + dt.ToString() + "')";
                //int result = God_admin.admin.In(select);
                int result = 0;
                try
                {
                    using (var db = new blogEntities())
                    {
                        var bl = new blog();
                        bl.title = admin.TextC(Title.Text);
                        bl.time = dt;
                        bl.describe = Describe.Text;
                        bl.text = admin.TextC(Body.Text);
                        bl.StudentID = Convert.ToInt32(Session["id"].ToString());
                        db.blog.Add(bl);
                        db.SaveChanges();
                    }
                    result = 1;
                }
                catch { }
                if (result == 1)
                {
                    Response.Write("<script>alert('发表成功');window.window.location.href='editor.aspx';</script> ");
                }
                else
                {
                    Response.Write("<script>alert('发表失败')</script>");
                }
            }

        }
        else
        {
            Response.Write("<script>alert('正文和标题不能为空')</script>");
        }
    }
}