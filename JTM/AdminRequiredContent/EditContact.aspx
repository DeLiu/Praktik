<%@ Page Language="C#" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditContact.aspx.cs" Inherits="AdminRequiredContent_EditContact" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">

    <style type="text/css">
    </style>

</asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="innerContentHolder">
        <h4>Rediger Kontakt</h4>
        <div class="contentHolder">
            <table class="ContentTable">
                <tr>
                    <td class="titleCell">
                        <label runat="server">Adresse: </label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="titleCell">
                        <label runat="server">By: </label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="titleCell">
                        <label runat="server">Postnr: </label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="PostalTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="titleCell">
                        <label runat="server">Tlf: </label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="titleCell">
                        <label runat="server">Mobil: </label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="HandphoneTexbox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td class="buttonCell">
                        <asp:Button ID="Save_button" runat="server" Text="Gem" OnClick="Save_button_Click" Width="100%" /></td>
                    <td/>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
