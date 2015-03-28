<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>博客</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_small.gif" />
        <asp:Button ID="Rallpicture" runat="server" OnClick="Rallpicture_Click" Text="图片站" />
        <asp:Button ID="enter1" runat="server" Text="编辑我的博客" OnClick="enter1_Click" Visible="false"/>
        <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="用户名" Visible="false"></asp:Label>
        <asp:TextBox ID="account" runat="server" Visible ="false"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="密码" Visible="false"></asp:Label>
        <asp:TextBox ID="password" runat="server" Visible="false" TextMode="Password"></asp:TextBox>
        <asp:Label runat="server" Text="labal" Visible="false" ID="name"></asp:Label>
        <asp:LinkButton ID="login1" runat="server" Font-Size="Small" OnClick="LinkButton2_Click" Text="登录"></asp:LinkButton>
        <asp:LinkButton ID="register" runat="server" Font-Size="Small" Visible ="false" OnClick="register_Click">注册</asp:LinkButton>
    </h1>
    </div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table border:"10" style="width: 50%;">
            </HeaderTemplate>


            <ItemTemplate>
                <tr>
                    <td><hr />
                        <a href='<%#Eval("ID","article.aspx?id={0}")%>'><%#Eval("title")%></a><br />
                         作者:<%#Eval("name1")%>发表时间:<%#Eval("time")%><br /><%#Eval("describe")%></td>
               </tr>
            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:LinkButton ID="first_page" runat="server" OnClick="first_page_Click" Enabled="true">首页</asp:LinkButton>
        <asp:LinkButton ID="last_page" runat="server" OnClick="last_page_Click" Enabled="true">上一页</asp:LinkButton>
        <asp:Label ID="now1" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="next_page" runat="server" OnClick="next_page_Click" Enabled="true">下一页</asp:LinkButton>
        <asp:LinkButton ID="final_page" runat="server" OnClick="final_page_Click" Enabled="true">末页</asp:LinkButton>
        <hr />
     </form>
    <p>
        &nbsp;</p>
</body>
</html>
