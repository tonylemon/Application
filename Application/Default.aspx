<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Application.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .list td{
            border-bottom-width:1px;
            border-bottom-style:dashed;
            border-bottom-color:#0094ff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <div>以下为各类客户端访问历史记录</div>
        <div>PC端：<asp:Label ID="PC" runat="server" Text="Label"></asp:Label></div>
        <div>Android客户端：<asp:Label ID="Android" runat="server" Text="Label"></asp:Label></div>
        <div>Iphone客户端：<asp:Label ID="Iphone" runat="server" Text="Label"></asp:Label></div>
        <div>Ipad客户端：<asp:Label ID="Ipad" runat="server" Text="Label"></asp:Label></div>
        </div>
    </form>
</body>
</html>
