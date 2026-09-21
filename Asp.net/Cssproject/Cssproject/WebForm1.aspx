<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Cssproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        h1{
            color:rebeccapurple;
        }
        .C1{
            color:aqua;
        }
        h1,.C1{
            background-color:cadetblue;
        }
        div h1{
            color:tomato;
        }
        div~h1{
            color:burlywood;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Random</h1>
        <div>
            <h1>Hi Hello!!</h1>
            <h1>Me Jerinn</h1>
            <h1 id="id1">Helllo</h1>
            <h2 class="C1">March</h2>
            <h2 class="C2">August</h2>
        </div>
        <div>
            <h1>Myself</h1>
        </div>
    </form>
</body>
</html>
