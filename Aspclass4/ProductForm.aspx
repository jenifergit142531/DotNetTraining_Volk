<%@ Page Title="" Language="C#" MasterPageFile="~/ContosoBookShop.Master" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Aspclass4.ProductForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
<br />
    <br />
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="gid" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="gid" HeaderText="gid" ReadOnly="True" SortExpression="gid" />
            <asp:BoundField DataField="gname" HeaderText="gname" SortExpression="gname" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoConnectionString %>" SelectCommand="SELECT * FROM [gaming]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
