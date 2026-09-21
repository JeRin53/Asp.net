<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Javascript_example.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var n = 12345, r = 0;
        while (n > 0) {
            a = n % 10;
            r = r * 10 + a;
            n = Math.floor(n / 10);
        }
        document.write(r);

        document.write("</br>");
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
