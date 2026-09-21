<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Aug17th.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        h1{
            color:darkgoldenrod;
           
        }
        #id1{
            color:firebrick;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <link href="StyleSheet1.css" rel="stylesheet" />
            <center><h1>Registeration Form</h1></center>
            <table align="center">
                <tr><td><label>Name:</label></td> <td><input type="text" id="t1" name="txtna" placeholder="Enter the name"</td></tr>
                <tr>
                    <td><label>Password:</label></td>
                    <td><input type="password" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
