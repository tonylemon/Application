<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Application.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width:60%">
            <tr style="text-align:center; background-color:#bdbdbd"><td style="height:30px">已选车次</td><td>请选择坐席</td><td>请选择购票张数</td><td>操作</td></tr>
            <tr style="text-align:center;">
                <td style="height:30px"><%=TarinNo %></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="2" Text="二等座"></asp:ListItem>
                        <asp:ListItem Value="1" Text="一等座"></asp:ListItem>
                        <asp:ListItem Value="100" Text="特等座"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="1" Text="1张"></asp:ListItem>
                        <asp:ListItem Value="2" Text="2张"></asp:ListItem>
                        <asp:ListItem Value="3" Text="3张"></asp:ListItem>
                        <asp:ListItem Value="4" Text="4张"></asp:ListItem>
                        <asp:ListItem Value="5" Text="5张"></asp:ListItem>
                        <asp:ListItem Value="6" Text="6张"></asp:ListItem>
                        <asp:ListItem Value="7" Text="7张"></asp:ListItem>
                        <asp:ListItem Value="8" Text="8张"></asp:ListItem>
                        <asp:ListItem Value="9" Text="9张"></asp:ListItem>
                        <asp:ListItem Value="10" Text="10张"></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td><asp:Button ID="Button1" runat="server" Text="结算" OnClick="Button1_Click" /></td>
            </tr>            
        </table>
        </div>
        <asp:HiddenField ID="HiddenField1" runat="server" />
    </form>
</body>
</html>
