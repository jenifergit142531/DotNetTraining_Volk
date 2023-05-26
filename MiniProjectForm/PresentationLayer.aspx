<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresentationLayer.aspx.cs" Inherits="MiniProjectForm.PresentationLayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Contoso Game Store"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Game Id"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Game Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Game" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Game" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
