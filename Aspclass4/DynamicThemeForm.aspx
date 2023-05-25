<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicThemeForm.aspx.cs" Inherits="Aspclass4.DynamicThemeForm"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Choose Theme"></asp:Label>
            <br />
            <br />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
          <asp:ListItem>default</asp:ListItem>
            <asp:ListItem>red</asp:ListItem>
            <asp:ListItem>blue</asp:ListItem>
            <asp:ListItem>green</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
