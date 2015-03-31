<%@ Page Language="C#" AutoEventWireup="true" CodeFile="article.aspx.cs" Inherits="article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title><%=Title.Text%></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    <h1>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/logo_small.gif" />
        <asp:Button ID="return1" runat="server" Text="主页" OnClick="return_Click" style="height: 21px" />
        <a href='<%#Eval("home.aspx")%>'></a>
        <asp:Button ID="enter1" runat="server" Text="编辑我的博客" OnClick="enter1_Click" Visible="false"/>
        <asp:Label ID="Label1" runat="server" Font-Size="Small" Text="用户名" Visible="false"/>
        <asp:TextBox ID="account" runat="server" Visible ="false"/>
        <asp:Label ID="Label2" runat="server" Font-Size="Small" Text="密码" Visible="false"/>
        <asp:TextBox ID="password" runat="server" Visible="false" TextMode="Password"/>
        <asp:Label runat="server" Text="labal" Visible="false" ID="name"></asp:Label>
        <asp:LinkButton ID="login1" runat="server" Font-Size="Small" OnClick="LinkButton2_Click" Text="登录"/>
        <asp:LinkButton ID="register" runat="server" Font-Size="Small" Visible ="false" OnClick="register_Click">注册</asp:LinkButton>
    </h1>
        <p>
            <asp:Button ID="update" runat="server" Text="编辑该文章" OnClick="update_Click" />
&nbsp;&nbsp;&nbsp;
    </p>
    </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    
        <asp:Label ID="Title" runat="server" Font-Size="XX-Large" Text="le"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Describe" runat="server" Font-Size="X-Small" Text="Label" BackColor="#999966"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Body" runat="server" Text="Label" OnDataBinding="Body_DataBinding" Width="580px"></asp:Label>
    
        <br />
        <br />
        <asp:Repeater ID="Repeater1" runat="server">
              <HeaderTemplate>
                <table border:"10" style="width: 50%;">
            </HeaderTemplate>


            <ItemTemplate>
                <tr>
                    <td><hr />
                         评论人:<%#Eval("name1")%>评论时间:<%#Eval("time")%><br /><%#Eval("text")%></td>
               </tr>
            </ItemTemplate>
            
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:LinkButton ID="first_page" runat="server" Enabled="true" OnClick="first_page_Click">首页</asp:LinkButton>
        <asp:LinkButton ID="last_page" runat="server" Enabled="true" OnClick="last_page_Click">上一页</asp:LinkButton>
        <asp:Label ID="now1" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="next_page" runat="server" Enabled="true" OnClick="next_page_Click">下一页</asp:LinkButton>
        <asp:LinkButton ID="final_page" runat="server" Enabled="true" OnClick="final_page_Click">末页</asp:LinkButton>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="68px" Width="472px" TextMode="MultiLine" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="button1" runat="server" Height="24px" Text="发表评论" OnClick="button1_Click" />
    
        <br />
    
    </div>
    </form>
</body>
</html>
