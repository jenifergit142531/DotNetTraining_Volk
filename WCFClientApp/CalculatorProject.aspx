<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorProject.aspx.cs" Inherits="WCFClientApp.CalculatorProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 399px;
            height: 256px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Calculator"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
