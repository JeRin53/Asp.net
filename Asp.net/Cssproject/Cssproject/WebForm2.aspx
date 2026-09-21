<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Cssproject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #id1{
            text-align:left;
            color:darkgoldenrod;
            font-size:xx-large;
            font-family:'Times New Roman';
            font-style:normal;
        }
        #id2{
            text-align:right;
            color:#ff0000;
            font-size:50px;
            font-style:oblique;
        }
        #id3{
            text-align:center;
            color:rgb(26 35 72 / 0.80);
            font-size:100px;
            font-style:italic;
        }
        #id4{
            text-align:justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="id1">Left</h1>
            <h1 id="id2">right</h1>
            <h1 id="id3">Middle</h1>
            <h1 id="id4">Justify</h1>
        </div>
    </form>
</body>
</html>
