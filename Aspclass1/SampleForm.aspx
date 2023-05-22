<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleForm.aspx.cs" Inherits="Aspclass1.SampleForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        
         
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="gid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
                <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand="SELECT * FROM [gaming]"></asp:SqlDataSource>
      
        <asp:DataList ID="DataList1" runat="server" DataKeyField="gid" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                DataList Control
            </HeaderTemplate>
            <HeaderStyle BackColor="Red" ForeColor="YellowGreen" Font-Size="X-Large" />
            <ItemTemplate>
                gid:
                <asp:Label ID="gidLabel" runat="server" Text='<%# Eval("gid") %>' />
                <br />
                gname:
                <asp:Label ID="gnameLabel" runat="server" Text='<%# Eval("gname") %>' />
                <br />
                <br />
                
            </ItemTemplate>
        </asp:DataList>
        
         
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="gid" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
                <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
            </Fields>
        </asp:DetailsView>
        
         
    </form>
</body>
</html>
