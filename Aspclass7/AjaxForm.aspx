<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxForm.aspx.cs" Inherits="Aspclass7.AjaxForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:AdRotator ID="AdRotator1" runat="server" Width="150px" Height="150px" DataSourceID="XmlDataSource1" />
                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
            </ContentTemplate>
        </asp:UpdatePanel>

        &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;
        &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;
        &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                <br />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
            <ProgressTemplate>
                <span style="background-color:red">Please wait while the page is loading......</span>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <br />
    </form>
</body>
</html>
