<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm11.aspx.vb" Inherits="Javascript_example.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class A {
            constructor() {
                console.log("Constructor");
            }
            check() {
                console.log("Non Abstract method");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
