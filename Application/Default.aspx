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
        <hr></h>  <!--两道横线-->
        <hr></hr>
        <div>
    <table align="center" style="border-collapse:collapse;border-spacing:1px;text-align:center; width:1000px">
        <tr style="background-color:#0094ff;color:#fff;text-align:center;">
            <td style="width:100px;height:40px;text-align:center">车次</td>
            <td style="width:150px;text-align:center"><div>出发站</div><div>到达站</div></td>
            <td style="width:200px"><div>出发时间</div><div>到达时间</div></td>
            <td style="width:100px">历时</td>
            <td style="width:100px">特等座</td>
            <td style="width:100px">一等座</td>
            <td style="width:100px">二等座</td>
            <td style="width:100px;text-align:center">预定</td>
        </tr>
        <%IList<TarinNoInfo> TarinNoInfos = CreateTarinNoInfo.Get();
            foreach (TarinNoInfo tarinNoInfo in TarinNoInfos)
            {%>
                <tr class="list" style="text-align:center;">
                    <td style="height:50px"><%=tarinNoInfo.TarinNo %></td>
                    <td><div><%=tarinNoInfo.FirstStation %></div><div><%=tarinNoInfo.LastStation %></div></td>
                    <td><div><%=tarinNoInfo.FirstTime %></div><div><%=tarinNoInfo.LastTime %></div></td>
                    <td><%=tarinNoInfo.ToLast %></td>
                    <td><%=tarinNoInfo.FirstClass %></td>
                    <td><%=tarinNoInfo.BusinessClass %></td>
                    <td><%=tarinNoInfo.EconomyClass %></td>
                    <td align="center">                    
                        <a style="display:block;width:80px;height:30px;line-height:30px;background-color:#0094ff;color:#fff;text-align:center;text-decoration:none;" href="order.aspx?TarinNo=<%=tarinNoInfo.TarinNo %>">预定</a>
                    </td>
                </tr>
            <%
                SetApplication(tarinNoInfo.TarinNo,tarinNoInfo.FirstClass,tarinNoInfo.BusinessClass,tarinNoInfo.EconomyClass);
            }
             %>
    </table>
    </div>
    </form>
</body>
</html>
