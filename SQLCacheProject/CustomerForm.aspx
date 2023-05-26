<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="SQLCacheProject.CustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>

                    Customers</legend>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Number of Customers :"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Data Retrived from :"></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Time Elapsed :"></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reload" />
            </fieldset>
        </div>
    </form>
</body>
</html>
