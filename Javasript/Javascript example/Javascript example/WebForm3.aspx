<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="Javascript_example.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        y = 200;
        function display() {
            var x = 100;
            document.write("Inside the function x:" + x);
            document.write("</br>");
            document.write("Inside the function y:" + y);
        }
        display();
        document.write("</br>");
        document.write("Outside the function y:" + y);
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
