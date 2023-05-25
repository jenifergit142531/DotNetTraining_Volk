<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LINQDSForm.aspx.cs" Inherits="DataSourceControls.LINQDSForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Gid" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="Gid" HeaderText="Gid" ReadOnly="True" SortExpression="Gid" />
                <asp:BoundField DataField="GameName" HeaderText="GameName" SortExpression="GameName" />
                <asp:BoundField DataField="maxPlayers" HeaderText="maxPlayers" SortExpression="maxPlayers" />
                <asp:BoundField DataField="gametype" HeaderText="gametype" SortExpression="gametype" />
                <asp:BoundField DataField="level" HeaderText="level" SortExpression="level" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataSourceControls.DataClasses1DataContext" EntityTypeName="" OrderBy="GameName desc" TableName="Games">
        </asp:LinqDataSource>
    </form>
</body>
</html>
