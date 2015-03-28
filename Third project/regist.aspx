<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regist.aspx.cs" Inherits="regist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    <h1>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_small.gif" />
        <asp:Button ID="return1" runat="server" Text="主页" OnClick="return_Click" style="height: 21px" />
        <a href='<%#Eval("home.aspx")%>'></a>
    </h1>
    </div>
    
    </div>
    
        <asp:Label ID="Tips" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="账号:"></asp:Label>
        <asp:TextBox ID="account" runat="server" Height="19px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Font-Size="Small" ForeColor="Red" Text="账号由6-16位英文字母或数字构成"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="密码:"></asp:Label>
        <asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Font-Size="Small" ForeColor="Red" Text="密码由4-16位英文字母或数字构成"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="再次输入密码:"></asp:Label>
        <asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="姓名:"></asp:Label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="sure1" runat="server" Text="确认注册" OnClick="sure1_Click" />
    </form>
</body>
</html>
