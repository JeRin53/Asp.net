<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm13.aspx.vb" Inherits="Javascript_example.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
        <div>
            <script>
                function Fun_propmpt() {
                    let text;
                    let name = prompt("Please enter your name:", "Edwin");
                    if (name == null || name== "") {
                        text = "User cancelled the prompt";
                    } else {
                        text = "Hello" + name + "! How are you today?";
                    }
                    document.getElementById("p1").innerHTML = text;
                }
            </script>
            <br />
            <input id="b2" type="submit" value="submit" onclick="Fun_Promt();" />
        </div>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="Fun_prompt();return false;" />
    </form>
</body>
</html>
