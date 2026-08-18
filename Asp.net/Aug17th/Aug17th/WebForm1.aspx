<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Aug17th.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" mode="post" action="WebForm2.aspx">
        <div>
            <p>My name is <span style="color:green;"> Jerin </span>and I am <span style="color:red;">21 </span>years old</p>

            <asp:Button ID="Button1" runat="server" Text="Click me" />
            <input id="Button2" type="button" value="Button" />
            <input id="Submit1" type="submit" value="submit" />
        </div>
    </form>
</body>
</html>
