<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm5.aspx.vb" Inherits="Javascript_example.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function sum(x,y) {
            z = x + y;
            return z;

        }
        var s=sum(200,100);
        document.write("Sum is" + s);
        document.write("</br>");
        document.write("Sum is :" + sum(20,10));
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
