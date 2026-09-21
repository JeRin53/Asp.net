<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm10.aspx.vb" Inherits="Javascript_example.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        class A {
            read() {
                this.x = 10;
                this.y = 20;
            }
        }

        class B extends A {
            sum() {
                this.s = this.x + this.y;
                console.log("Sum is :", this.s);
            }
        }

        class C extends B {
            avg() {
                console.log("Average is:", this.s / 2);
            }
        }

        var obj = new C();
        obj.read();
        obj.sum();
        obj.avg();
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
    </form>
</body>
</html>
