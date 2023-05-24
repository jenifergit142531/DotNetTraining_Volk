<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartialCacheForm.aspx.cs" Inherits="Aspclass3.PartialCacheForm" %>

<%@ Register src="Fragment1.ascx" tagname="Fragment1" tagprefix="uc1" %>
<%@ Register src="Fragment2.ascx" tagname="Fragment2" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <uc2:Fragment2 ID="Fragment21" runat="server" />
        <p>
            <uc1:Fragment1 ID="Fragment11" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
