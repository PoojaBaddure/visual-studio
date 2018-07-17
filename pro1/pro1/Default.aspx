<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pro1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="enter first number"></asp:Label>
    <asp:TextBox ID="t1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="enter second number"></asp:Label>
    <asp:TextBox ID="t2" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="result"></asp:Label>
    <asp:TextBox ID="t3" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="max" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="min" />
    </p>
    </form>
</body>
</html>
