<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLDSForm.aspx.cs" Inherits="DataSourceControls.XMLDSForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="Favourite" TextField="Name" />
                <asp:TreeNodeBinding DataMember="Book" TextField="Name" />
                <asp:TreeNodeBinding DataMember="Movie" TextField="Name" />
                <asp:TreeNodeBinding DataMember="Vacation" TextField="Name" />
            </DataBindings>
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Game.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
