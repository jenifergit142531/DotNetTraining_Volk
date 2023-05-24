<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCacheForm.aspx.cs" Inherits="Aspclass3.PageCacheForm" %>
<%@ OutputCache Duration="5" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <%= DateTime.Now.ToString() %>
            <a href="?p=1">1</a>
            <a href="?p=2">2</a>
            <a href="?p=3">3</a>
        </div>
    </form>
</body>
</html>
