<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm6.aspx.vb" Inherits="Javascript_example.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function sum() {
            var a = parseInt(document.getElementById("t1").value);
            var b = parseInt(document.getElementById("t2").value);
            z = a + b;
            alert("Sum is:" + z);
        }
        document.write("</br>");
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="t1" type="text" />
            <input id="t2" type="text" />
            <input type="button" value="Submit" onclick="sum();"/>
            <br/>
            <asp:Button ID="button1" runat="server" text="button"
        </div>
    </form>
</body>
</html>
