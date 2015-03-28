using God_admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class picture : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_upload_Click(object sender, EventArgs e)
    {
        Boolean fileOk = false;
        if (pic_upload.HasFile)//验证是否包含文件
        {
            //取得文件的扩展名,并转换成小写
            string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
            //验证上传文件是否图片格式
            fileOk = IsImage(fileExtension);

            if (fileOk)
            {
                //对上传文件的大小进行检测，限定文件最大不超过8M
                if (pic_upload.PostedFile.ContentLength < 8192000)
                {
                    string filepath = "/images/";
                    if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                    {
                        Directory.CreateDirectory(Server.MapPath(filepath));
                    }
                    string virpath = filepath + CreatePasswordHash(pic_upload.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                    DateTime dt = new DateTime();
                    dt = DateTime.Now;
                    string select = "INSERT INTO picture VALUES('" + virpath + "'," + Session["id"] + ",'" + dt.ToString() + "')";
                    int result = admin.In(select);
                    Response.Write("<script>alert('上传成功')</script>");
                    string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                    pic_upload.PostedFile.SaveAs(mappath);//保存图片
                    pic.ImageUrl = virpath;
                    lbl_pic.Text = "";
                }
                else
                {
                    pic.ImageUrl = "";
                    lbl_pic.Text = "文件大小超出8M！请重新选择！";
                }
            }
            else
            {
                pic.ImageUrl = "";
                lbl_pic.Text = "要上传的文件类型不对！请重新选择！";
            }
        }
        else
        {
            pic.ImageUrl = "";
            lbl_pic.Text = "请选择要上传的图片！";
        }
    }

    public bool IsImage(string str)
    {
        bool isimage = false;
        string thestr = str.ToLower();
        //限定只能上传jpg和gif图片
        string[] allowExtension = { ".jpg", ".gif", ".bmp", ".png" };
        for (int i = 0; i < allowExtension.Length; i++)
        {
            if (thestr == allowExtension[i])
            {
                isimage = true;
                break;
            }
        }
        return isimage;
    }

    public string CreateSalt(int saltLenght) //创建salt值
    {
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] buff = new byte[saltLenght];
        rng.GetBytes(buff);
        return Convert.ToBase64String(buff);
    }



    public string CreatePasswordHash(string pwd, int saltLenght) // 返回加密的字符串
    {
        string strSalt = CreateSalt(saltLenght);
        string saltAndPwd = String.Concat(pwd, strSalt);
        string hashenPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
        hashenPwd = hashenPwd.ToLower().Substring(0, 16);
        return hashenPwd;
    }
    protected void return1_Click(object sender, EventArgs e)
    {
        Response.Redirect("allpicture.aspx");
    }
}