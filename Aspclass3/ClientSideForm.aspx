<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientSideForm.aspx.cs" Inherits="Aspclass3.ClientSideForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 178px;
        }
        .auto-style2 {
            margin-bottom: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="View State"></asp:Label>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
        </p>
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Width="331px" Height="142px">
            <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Restore" />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" CssClass="auto-style2" Height="234px" Width="431px">
                <asp:Label ID="Label5" runat="server" Text="Querystring"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Employee Name"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:Panel>
        </asp:Panel>
        <p>
&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Department"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Enter Cookie value"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Create Cookie" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Retrieve Cookie" />
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
