<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editor.aspx.cs" Inherits="editor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>我的博客</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    <h1>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_small.gif" />
        <asp:Button ID="return1" runat="server" Text="主页" OnClick="return_Click" style="height: 21px" />
        <asp:Label runat="server" Text="labal" Visible="true" ID="name"></asp:Label>
        <asp:LinkButton ID="login1" runat="server" Font-Size="Small" OnClick="LinkButton2_Click" Text="注销"></asp:LinkButton>
        <asp:Button ID="enter2" runat="server" OnClick="enter2_Click" Text="发表新文章" />
    </h1>
    </div>
    
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="EandD">
            <HeaderTemplate>
                <table border:"10" style="width: 50%;">
            </HeaderTemplate>


            <ItemTemplate>
                <tr>
                    <td><hr />
                        <a href='<%#Eval("ID","article.aspx?id={0}")%>'><%#Eval("title")%></a><br />
                        发表时间:<%#Eval("time")%><br /><%#Eval("describe")%><br /><asp:LinkButton ID="editor" runat="server" CommandName="editor" CommandArgument='<%#Eval("ID")%>' Text="编辑" />
                        <asp:LinkButton ID="delete" runat="server" CommandName="delete" CommandArgument='<%#Eval("ID")%>' Text="删除"  OnClientClick='return confirm("确定删除?")'/>
                </td>
                </tr>
            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    
        <br />
        <asp:LinkButton ID="first_page" runat="server" OnClick="first_page_Click" Enabled="true">首页</asp:LinkButton>
        <asp:LinkButton ID="last_page" runat="server" OnClick="last_page_Click" Enabled="true">上一页</asp:LinkButton>
        <asp:Label ID="now1" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="next_page" runat="server" OnClick="next_page_Click" Enabled="true">下一页</asp:LinkButton>
        <asp:LinkButton ID="final_page" runat="server" OnClick="final_page_Click" Enabled="true">末页</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
