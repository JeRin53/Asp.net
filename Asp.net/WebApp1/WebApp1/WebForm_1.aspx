<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_1.aspx.cs" Inherits="WebApp1.WebForm_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td id="lbl1">
                    <asp:Label ID="lbl1" runat="server" Text="Number 1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                </td>
                <td id="lbl2">
                    <asp:Label ID="lbl2" runat="server" Text="Number 2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Height="115px" OnClick="Button1_Click" Text="+" Width="141px" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" Height="115px" OnClick="Button2_Click" Text="-" Width="141px" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="Large" Height="115px" OnClick="Button3_Click" Text="/" Width="141px" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Large" Height="115px" OnClick="Button4_Click" Text="*" Width="141px" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
