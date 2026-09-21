<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm9.aspx.vb" Inherits="Javascript_example.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class Colour {
            constructor(id, name) {
                this.id = id;
                this.name = name;
            }
            display() {
                document.writeln(this.id + " " + this.name+"<br>");
            }
        }

        var e1 = new Colour(1, "red");
        e1.display();
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
