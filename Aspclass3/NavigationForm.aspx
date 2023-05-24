<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavigationForm.aspx.cs" Inherits="Aspclass3.NavigationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="gid" DataSourceID="SqlDataSource1" AllowPaging="true">
            <EditItemTemplate>
                gid:
                <asp:Label ID="gidLabel1" runat="server" Text='<%# Eval("gid") %>' />
                <br />
                gname:
                <asp:TextBox ID="gnameTextBox" runat="server" Text='<%# Bind("gname") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                gid:
                <asp:TextBox ID="gidTextBox" runat="server" Text='<%# Bind("gid") %>' />
                <br />
                gname:
                <asp:TextBox ID="gnameTextBox" runat="server" Text='<%# Bind("gname") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                gid:
                <asp:Label ID="gidLabel" runat="server" Text='<%# Eval("gid") %>' />
                <br />
                gname:
                <asp:Label ID="gnameLabel" runat="server" Text='<%# Bind("gname") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString2 %>" SelectCommand="SELECT * FROM [gaming]"></asp:SqlDataSource>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" ShowLines="True">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="DeptId" Text="100" Value="100" />
                <asp:TreeNodeBinding DataMember="DeptName" Text="HR" Value="HR" />
                <asp:TreeNodeBinding DataMember="EmployeeCount" Text="100" Value="100" />
                <asp:TreeNodeBinding DataMember="DeptId" Text="200" Value="200" />
            </DataBindings>
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
