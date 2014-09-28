<%@ Page Language="C#" Title="Rediger Profil" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditProfilePage.aspx.cs" Inherits="AdminRequiredContent_EditProfilePage" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="content-wrapper">
        <div class="innerContentHolder">
            <h4>Rediger Profiltekst</h4>
            <div class="contentHolder">
                <table class="ContentTable">
                    <tr>
                        <td colspan="3">
                            <asp:TextBox ID="profilEditTextBox" CssClass="profilTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="buttonCell">
                            <asp:Button ID="Save_button" runat="server" Text="Gem" OnClick="Save_button_Click" Width="100%" /></td>
                        <td class="buttonCell"></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
