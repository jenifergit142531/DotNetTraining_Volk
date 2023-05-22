<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryExtender.aspx.cs" Inherits="Aspclass1.QueryExtender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Please filter by GameName : "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>

           <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="gid">
            <Columns>
                <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
                <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString4 %>" SelectCommand="SELECT * FROM [gaming]"></asp:SqlDataSource>
       

      <!--  <asp:QueryExtender ID="QueryExtender1" runat="server" TargetControlID="SqlDataSource1">
            <asp:SearchExpression DataFields="gname" SearchType="StartsWith">
                <asp:ControlParameter ControlID="TextBox1"/>
            </asp:SearchExpression>
        </asp:QueryExtender>
        -->
     
    </form>
</body>
</html>
 