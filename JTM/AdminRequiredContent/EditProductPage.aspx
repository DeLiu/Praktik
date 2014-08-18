<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProductPage.aspx.cs" Inherits="AdminRequiredContent_EditProductPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type ="text/css">
        .alignRight {text-align : right;
                     vertical-align : top;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Produkter</h1>
            <table style="width: 500px;">
            <tr>
                <th colspan="2" style="text-align : left">Opret Produkt</th>
            </tr>
            <tr>
                <td class="alignRight"><label runat="server">Produktsnavn: </label></td>
                <td><asp:TextBox ID="navnTextbox" runat="server"></asp:TextBox></td>
            </tr>
                <tr>
                    <td class="alignRight"><label runat="server">Mængde: </label></td>
                    <td><asp:TextBox ID="amountTextBox" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td class="alignRight"><label title="Pris excl. moms" runat="server">Pris: </label></td>
                <td><asp:TextBox ID="prisTextbox" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="alignRight"><label title="Eventuelt indtast produktbeskrivelse" runat="server">Information: </label></td>
                <td><asp:TextBox ID="infoTextbox" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
            </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="confirmButton" runat="server" Text="Bekræft" OnClick="confirmButton_Click"/></td>

                </tr>
            </table>
        <br />

    </div>
    </form>
</body>
</html>
