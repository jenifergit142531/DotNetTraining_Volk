<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectForm.aspx.cs" Inherits="DataSourceControls.ObjectForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
            <LayoutTemplate>
                <table>
                    <tr>
                        <td>
                            Student ID
                        </td>
                         <td>
                            Student Name
                        </td>
                         <td>
                            City
                        </td>
                    </tr>
                    <tr id="ItemPlaceHolder" runat="server">
                </tr>
                    <tr>
                        <td>
                            <asp:DataPager ID="DataPager1" runat="server">
                                
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Link" />
                                <asp:NumericPagerField ButtonType="Link" />
                            </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                   
                       
            
                </table>
            </LayoutTemplate>
            
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:Label Id="l1" runat="server" text='<%# Eval("StudentId")%>'>

                            </asp:Label>

                        </td>
                         <td> 
                             <asp:Label Id="l2" runat="server" text='<%# Eval("StudentName") %>'>

                             </asp:Label>

                         </td>
                         <td> 
                             <asp:Label Id="l3" runat="server" text='<%# Eval("StudentCity") %>'>

                             </asp:Label>

                         </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:ListView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetStudents" TypeName="DataSourceControls.Student"></asp:ObjectDataSource>
    </form>
</body>
</html>
