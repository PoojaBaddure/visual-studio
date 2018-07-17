<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginform.aspx.cs" Inherits="loginform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #33CC33;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 142px;
        }
        .auto-style4 {
            width: 142px;
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>LOGIN FORM</strong><table class="auto-style2">
                <tr>
                    <td class="auto-style4">username</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="347px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="346px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="14pt" OnClick="Button1_Click" Text="LOGIN" Width="95px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
