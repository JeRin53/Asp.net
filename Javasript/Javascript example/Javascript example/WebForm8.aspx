<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm8.aspx.vb" Inherits="Javascript_example.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="demo"></p>

            <script>
                let prime_numbers = [2, 3, 5, 7, 9, 11];
                /*prime_numbers.splice(2, 1, 100)*/
                /*prime_numbers.splice(2,2)*/
                prime_numbers.splice(2)

                /*prime_numbers.splice(1, 2, 100, 200)*/
                document.getElementById("demo").innerHTML = prime_numbers;
            </script>
        </div>
    </form>
</body>
</html>
