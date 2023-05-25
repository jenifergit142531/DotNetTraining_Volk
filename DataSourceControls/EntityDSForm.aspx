<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntityDSForm.aspx.cs" Inherits="DataSourceControls.EntityDSForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="gid" DataSourceID="EntityDataSource1">
            <Fields>
                <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
                <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
            </Fields>
        </asp:DetailsView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=DemoEntities3" DefaultContainerName="DemoEntities3" EnableFlattening="False" EntitySetName="gamings">
        </asp:EntityDataSource>
    </form>
</body>
</html>
