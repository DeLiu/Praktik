<%@ Page Language="C#" Title="Rediger Links" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditLinks.aspx.cs" Inherits="AdminRequiredContent_EditLinks" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">

    <style type="text/css">

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
                            <td>
                                <label>Link Adresse: </label>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="titleTextBox" runat="server" Width="100%"></asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="linkTextBox" runat="server" Width="100%"></asp:TextBox></td>
                            <td class="buttonCell">
                                <asp:Button ID="Add_button" runat="server" Text="Tilføj" OnClick="add_button_Click" Width="100%" /></td>
                        </tr>
                    </table>
                </div>               
            </div>
            <div class="innerContentHolder">
                <h4>Tilføjede Links</h4>
                <div class="contentHolder GridHolder">
                    <asp:GridView ID="GridView1" CssClass="ContentTable" runat="server" DataSourceID="linkDataSource" AutoGenerateColumns="False" DataKeyNames="linkId">
                        <Columns>
                            <asp:BoundField DataField="linkId" HeaderText="linkId" ReadOnly="True" SortExpression="linkId" Visible="False" />
                            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" Visible="False" />
                            <asp:BoundField DataField="link" HeaderText="link" SortExpression="link" Visible="False" />
                            <asp:HyperLinkField DataNavigateUrlFields="link" DataNavigateUrlFormatString="http://{0}" DataTextField="title" HeaderText="Title" Target="_self">                            
                            <HeaderStyle Width="20%" />
                            </asp:HyperLinkField> 
                            <asp:HyperLinkField DataNavigateUrlFields="link" DataNavigateUrlFormatString="http://{0}" DataTextField="link" HeaderText="Links" Target="_self" />
                            <asp:CommandField ButtonType="Button" CancelText="Annullér" DeleteText="Slet" EditText="Rediger" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Opdater" >
                            <ControlStyle Width="70px" />
                            <HeaderStyle Width="160px" />
                            </asp:CommandField>
                        </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="linkDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [links] WHERE [linkId] = @linkId" InsertCommand="INSERT INTO [links] ([linkId], [title], [link]) VALUES (@linkId, @title, @link)" SelectCommand="SELECT * FROM [links]" UpdateCommand="UPDATE [links] SET [title] = @title, [link] = @link WHERE [linkId] = @linkId">
                            <DeleteParameters>
                                <asp:Parameter Name="linkId" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="linkId" Type="Int32" />
                                <asp:Parameter Name="title" Type="String" />
                                <asp:Parameter Name="link" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="title" Type="String" />
                                <asp:Parameter Name="link" Type="String" />
                                <asp:Parameter Name="linkId" Type="Int32" />
                            </UpdateParameters>
                    </asp:SqlDataSource>
                </div>
            </div>
        
</asp:Content>
