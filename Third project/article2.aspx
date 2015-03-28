<%@ Page Language="C#" AutoEventWireup="true" CodeFile="article2.aspx.cs" Inherits="article2" %>

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
        <asp:Button ID="return1" runat="server" Text="返回" OnClick="return_Click" style="height: 21px" />
    </h1>
    </div>
    
        <br />
        <asp:Label ID="label1" runat="server" Text="标题:"></asp:Label>
        <asp:TextBox ID="Title" runat="server" Width="626px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="介绍:"></asp:Label>
        <asp:TextBox ID="Describe" runat="server" Width="625px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="内容:"></asp:Label>
        <br />
        <asp:TextBox ID="Body" runat="server" Height="321px" Width="634px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SureButton" runat="server" Text="保存" OnClick="SureButton_Click" />
    
    </div>
    </form>
</body>
</html>
