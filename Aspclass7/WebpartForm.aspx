<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebpartForm.aspx.cs" Inherits="Aspclass7.WebpartForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
        <br />
        <asp:CatalogZone ID="CatalogZone1" runat="server">
            <ZoneTemplate>
                <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
            </ZoneTemplate>
        </asp:CatalogZone>
        <br />
        <asp:WebPartZone ID="WebPartZone1" runat="server" HeaderText="My Calendar">
            <ZoneTemplate>
                <asp:EditorZone ID="EditorZone1" runat="server">
                    <ZoneTemplate>
                        <asp:BehaviorEditorPart ID="BehaviorEditorPart1" runat="server" />
                    </ZoneTemplate>
                </asp:EditorZone>
                <asp:WebPartZone ID="WebPartZone2" runat="server" HeaderText="User Login ">
                <ZoneTemplate>
                    <asp:Login ID="Login1" runat="server"></asp:Login>
                </ZoneTemplate>
                </asp:WebPartZone>
            </ZoneTemplate>
        </asp:WebPartZone>
    </form>
</body>
</html>
