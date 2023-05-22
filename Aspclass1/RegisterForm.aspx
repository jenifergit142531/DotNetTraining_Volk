<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="Aspclass1.RegisterForm" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" DisappearAfter="200">
            <Items>
                <asp:MenuItem NavigateUrl="~/HomeForm.aspx" Text="Home">

                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/AboutUs.aspx" Text="About Us">

                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/SampleForm.aspx" Text="MyDataForm">

                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <asp:Chart ID="Chart1" runat="server" Width="500px">
            <series>
                <asp:Series Name="Series1" XValueMember="0" YValueMembers="2">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </form>
</body>
</html>
