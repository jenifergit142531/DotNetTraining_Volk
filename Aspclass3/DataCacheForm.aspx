<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataCacheForm.aspx.cs" Inherits="Aspclass3.DataCacheForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="gid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
                <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand="SELECT * FROM [gaming]" EnableCaching="true" CacheDuration="20"></asp:SqlDataSource>
    </form>
</body>
</html>
