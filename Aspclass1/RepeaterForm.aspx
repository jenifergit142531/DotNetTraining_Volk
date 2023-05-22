<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterForm.aspx.cs" Inherits="Aspclass1.RepeaterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            
            <HeaderTemplate>
                <table class="tblcolor">
                    <tr>
                        <td>Game Id</td>
                         <td>Game Name</td>
                    </tr>
                 
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table>
                <tr> 
                    <td>
                        <%#DataBinder.Eval(Container,"DataItem.gid") %>
                    </td>
                     <td>
                        <%#DataBinder.Eval(Container,"DataItem.gname") %>
                    </td>
                </tr>
            </table>
            </ItemTemplate>
               
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString5 %>" SelectCommand="SELECT * FROM [gaming]"></asp:SqlDataSource>
    </form>
</body>
</html>


