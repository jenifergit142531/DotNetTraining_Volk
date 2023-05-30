<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DrpLanguages" AutoPostBack="true"  
 runat="server" Width="200px"  
OnSelectedIndexChanged="DrpLanguages_SelectedIndexChanged">  
<asp:ListItem Text="Select Languages" Value="0"></asp:ListItem>  
<asp:ListItem Text="English" Value="en-GB"></asp:ListItem>  
<asp:ListItem Text="Hindi" Value="hi-IN"></asp:ListItem>  
<asp:ListItem Text="arabic" Value="ar-SA"></asp:ListItem>  
</asp:DropDownList> 
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="<%$Resources:Resource, Hello%>"></asp:Label>
        </p>
    </form>
</body>
</html>
