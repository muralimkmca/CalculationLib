<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="UnitTestWeb._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>                    
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>                    
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>                    
                    <td></td>
                    <td>
                        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
