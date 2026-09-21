<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script>
    $(document).ready(function(){
      $("button").click(function(){
        $("p").hide();
      });
    });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>This is a heading</h2>

            <p>This is a paragraph.</p>
            <p>This is another paragraph.</p>

            <button>Click me to hide paragraphs</button>
        </div>
    </form>
</body>
</html>
