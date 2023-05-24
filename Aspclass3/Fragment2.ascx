
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Fragment2.ascx.cs" Inherits="Aspclass3.Fragment2" %>
<%@ OutputCache Duration="20" VaryByParam="none" VaryByControl="RadioButtonList1" %>
<asp:Label ID="Label1" runat="server" Text="Label">Do you Understand Caching ?</asp:Label>
<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
    <asp:ListItem>Yes</asp:ListItem>
    <asp:ListItem>No</asp:ListItem>
    <asp:ListItem>MayBe</asp:ListItem>

</asp:RadioButtonList>
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
