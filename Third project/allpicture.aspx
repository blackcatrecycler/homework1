<%@ Page Language="C#" AutoEventWireup="true" CodeFile="allpicture.aspx.cs" Inherits="allpicture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_small.gif" />
        <asp:Button ID="Rhome" runat="server" OnClick="Rhome_Click" Text="博客主页" />
        <asp:Button ID="enter1" runat="server" Text="上传我的图片" OnClick="enter1_Click" Visible="false"/>
        <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="用户名" Visible="false"></asp:Label>
        <asp:TextBox ID="account" runat="server" Visible ="false"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="密码" Visible="false"></asp:Label>
        <asp:TextBox ID="password" runat="server" Visible="false" TextMode="Password"></asp:TextBox>
        <asp:Label runat="server" Text="labal" Visible="false" ID="name"></asp:Label>
        <asp:LinkButton ID="login1" runat="server" Font-Size="Small" OnClick="LinkButton2_Click" Text="登录"></asp:LinkButton>
        <asp:LinkButton ID="register" runat="server" Font-Size="Small" Visible ="false" OnClick="register_Click">注册</asp:LinkButton>
    
    </div>
        <asp:Repeater ID="Repeater1" runat="server">
      <HeaderTemplate>
                <table border:"10" style="width: 50%;">
            </HeaderTemplate>


            <ItemTemplate>
                <tr>
                    <td>
                    <asp:Image runat="server" ImageUrl='<%#Eval("files")%>' /><br />
                    上传人：<%#Eval("name1")%>上传时间：<%#Eval("time")%></td>
               </tr>
            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
