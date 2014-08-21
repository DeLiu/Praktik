<%@ Page Language="C#" Title="Rediger Links" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditLinks.aspx.cs" Inherits="AdminRequiredContent_EditLinks" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">
        <link rel="stylesheet" type="text/css" href="CSS/CMS.css" />
    </asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <table style="width: 600px;">
            <tr>
                <td class="alignRight" style="width : 20%">
                    <label>Title: </label></td>
                <td style="width : 45%">
                    <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox></td>
                <td rowspan="3">
                    <ul id="listedLinks" runat="server">
                        <li>
                            <asp:HyperLink runat="server" NavigateUrl="http://fronter.com/eal">Fronter</asp:HyperLink>
                        </li>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="alignRight">
                    <label style="text-align : right">Link Adresse: </label></td>
                <td>
                    <asp:TextBox ID="linkTextBox" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    </td>
                <td>
                    <asp:Button ID="Add_button" runat="server" Text="Tilføj" OnClick="add_button_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
