﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProductPage.aspx.cs" Inherits="AdminRequiredContent_EditProductPage" %>

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
                <td class="alignRight"><label title="Indtast produktets type." runat="server">Produktstype: </label></td>
                <td><asp:TextBox ID="typeTextbox" runat="server"></asp:TextBox></td>
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
                <td class="alignRight"><label title="Eventuelt indtast produktbeskrivelse" runat="server">Beskrivelse: </label></td>
                <td><asp:TextBox ID="infoTextbox" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
            </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="confirmButton" runat="server" Text="Bekræft" OnClick="confirmButton_Click"/></td>

                </tr>
            </table>
        <br />
        <asp:GridView ID="EditProductGridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="graintype" HeaderText="graintype" SortExpression="graintype" />
                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="infomation" HeaderText="infomation" SortExpression="infomation" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductDBString %>" SelectCommand="SELECT [graintype], [amount], [price], [infomation] FROM [productinfo]"></asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
