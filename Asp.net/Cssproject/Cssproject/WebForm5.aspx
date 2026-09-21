<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm5.aspx.vb" Inherits="Cssproject.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #img1{
            border: 2px solid red;
            border-radius:60px;
            padding:10px;
            height:100px;
        }
        #img2{
            border:2px solid green;
            border-radius:20%;
            padding:5px;
            height:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>THumbanail image</h1>
            <img src="College2.jpg" id="img1" />
            <h1>Circle image</h1>
            <img src="College3.jpg" id="img2" />
        </div>
    </form>
</body>
</html>
