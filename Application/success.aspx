<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="Application.success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color:#008f0c;">
             购买成功,<span id="sec">5</span>秒后回到首页。
        </div>
    </form>
    <script type="text/javascript">
        var i=5;
        setInterval(function () {
            i--;
            document.getElementById("sec").innerText = i;
            if (i == 1) {
                window.location.href = "default.aspx";
            }            
        }, 1000);
    </script>
</body>
</html>
