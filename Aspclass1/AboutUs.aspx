<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Aspclass1.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CheckBoxList Control
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem>SQL</asp:ListItem>
            <asp:ListItem>ASP MVC</asp:ListItem>
            <asp:ListItem>Angular</asp:ListItem>
            <asp:ListItem>Microservices</asp:ListItem>
            <asp:ListItem>DevOps</asp:ListItem>
            <asp:ListItem>WebAPI</asp:ListItem>
           
        </asp:CheckBoxList>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
