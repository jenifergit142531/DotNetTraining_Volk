<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadForm.aspx.cs" Inherits="Aspclass3.FileUploadForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Upload Resume "></asp:Label>
            <br />
        </div>
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
