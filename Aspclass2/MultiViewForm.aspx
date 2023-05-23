<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewForm.aspx.cs" Inherits="Aspclass2.MultiViewForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 280px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            MultiView Control</div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View3" runat="server">
                    &nbsp;This is a home page&nbsp;- view 3
                </asp:View>
                <asp:View ID="View2" runat="server">
                    This is a recent listed page - view 2
                </asp:View>
                <asp:View ID="View1" runat="server">
                    This is a product page - view 1
                </asp:View>
            </asp:MultiView>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View1" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View2" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View3" />
        </p>
    </form>
</body>
</html>
