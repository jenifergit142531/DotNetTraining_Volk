<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeForm.aspx.cs" Inherits="Aspclass1.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is Query Extender page
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Please select by Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" DataKeyNames="sid" >
            <Columns>
                <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                <asp:BoundField DataField="squantity" HeaderText="squantity" SortExpression="squantity" />
                <asp:BoundField DataField="pid" HeaderText="pid" SortExpression="pid" />
            </Columns>
        </asp:GridView>
        
        <asp:QueryExtender ID="QueryExtender1" runat="server" TargetControlID="LinqDataSource1" >
        <asp:SearchExpression DataFields="pname" SearchType="StartsWith">
                <asp:ControlParameter ControlID="TextBox1"/>
            </asp:SearchExpression>
            </asp:QueryExtender>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Aspclass1.DataClasses2DataContext" EntityTypeName="" TableName="EStocks" >
        </asp:LinqDataSource>
    </form>
</body>
</html>
