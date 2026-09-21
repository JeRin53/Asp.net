<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm12.aspx.vb" Inherits="Javascript_example.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="p1"></p>
            <script>
                function Fun_confirm() {
                    var txt;
                    if (confirm("press a button!")) {
                        txt = "You Pressed OK!";

                    } else {
                        txt = "You Pressed Cancel!";
                    }
                    document.getElementById("p1").innerHTML = txt;
                }
            </script>

            <br />
            <input id="b2" type="submit" value="submit" onclick="Fun_confirm();" />
        </div>
    </form>
</body>
</html>
