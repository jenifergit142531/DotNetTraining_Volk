<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdForm.aspx.cs" Inherits="Aspclass2.AdForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            AdRotator - Book Shop</div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
        <asp:Timer ID="Timer1" runat="server" Interval="500">
        </asp:Timer>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                
            </Triggers>
            <ContentTemplate>
                 <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AdBook.xml" Height="500px" Width="500px" />
        
            </ContentTemplate>

        </asp:UpdatePanel>

    </form>
</body>
</html>
