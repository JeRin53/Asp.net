<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
 <script>
    $(document).ready(function () {
        $("#button0").click(function () {
            $("p").hide();
        });
    });
     $(document).ready(function () {
         $("#button1").click(function () {
             $("#test").hide();
         });
     });
 </script>
</head>
<body>
    <h2>This is a heading</h2>

<p>This is a paragraph.</p>
<p id="test">This is another paragraph.</p>


<button id="button0">Click me to hide paragraphs</button>
    <button id="button1">Click me to hide paragraphs with id</button>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
