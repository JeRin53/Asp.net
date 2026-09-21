<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm4.aspx.vb" Inherits="Cssproject.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    p.none
    <style>
        p{
            background-color:navajowhite;
        }
        p.P1{
            margin-top:50px;
            margin-left:10px;
            margin-right:100px;
            margin-bottom:100px;
        }
        p.P2{
            margin:100px 30px 20px 100px;
        }
        p.P3{
            margin:50px 20px 100px;
        }
        p.P4{
            margin:500px 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>I am an obidient boy</p>
            <p class="P1">I am also an obidient boy</p>
            <p class="P2">I am also an obidient boy</p>

            <p class="P3">I am also an obidient boy</p>
            <p class="P4">I am also an obidient boy</p>
        </div>
    </form>
</body>
</html>
