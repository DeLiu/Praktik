<%@ Page Language="C#" Title="Rediger Links" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditLinks.aspx.cs" Inherits="AdminRequiredContent_EditLinks" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">

    <style type="text/css">
    .auto-style1 {
        width: 605px;
    }
</style>

    </asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
            <div class="innerContentHolder">
                <h4>Tilføj Link</h4>
                <div class="contentHolder">
                    <table class="ContentTable">
                        <tr>
                            <td style="width: 20%">
                                <label>Title: </label>
                            </td>
                            <td class="auto-style1">
                                <label>Link Adresse: </label>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="titleTextBox" runat="server" Width="100%"></asp:TextBox>
                            </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="linkTextBox" runat="server" Width="100%"></asp:TextBox></td>
                            <td class="buttonCell">
                                <asp:Button ID="Add_button" runat="server" Text="Tilføj" OnClick="add_button_Click" Width="100%" /></td>
                        </tr>
                    </table>
                </div>               
            </div>
            <div class="innerContentHolder">
                <h4>Tilføjede Links</h4>
                <div class="contentHolder">
                    <table id="linksTable" class="ContentTable">
                        <tr>
                            <td style="width: 20%">
                                <label>Title: </label>
                            </td>
                            <td>
                                <label>Link Adresse: </label>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </div>
            </div>
        
</asp:Content>
