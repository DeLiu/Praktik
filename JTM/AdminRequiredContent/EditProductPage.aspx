<%@ Page Language="C#" Title="Rediger Produkter" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="EditProductPage.aspx.cs" Inherits="AdminRequiredContent_EditProductPage" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">
    <link rel="stylesheet" type="text/css" href="CSS/CMS.css" />
    </asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="content-wrapper">
        <div class="columnHolder-left">
            <h4>Opret Produkt</h4>
            <div class="contentHolder">
                <table class="ContentTable">
                    <tr>
                        <td class="titleCell">
                            <label runat="server">Produktsnavn: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="navnTextbox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="titleCell">
                            <label runat="server">Mængde: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="amountTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="titleCell">
                            <label title="Pris excl. moms" runat="server">Pris: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="prisTextbox" runat="server" TextMode="Number"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="titleCell">
                            <label title="Eventuelt indtast produktbeskrivelse" runat="server">Information: </label>
                        </td>
                        <td>
                            <asp:TextBox ID="infoTextbox" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="confirmButton" runat="server" Text="Bekræft" OnClick="confirm_Button_Click" /></td>

                    </tr>
                </table>
                <br />
            </div>
        </div>
        <div class="colummholder-right">
            <h4>Rediger Produkter</h4>
            <div class="contentHolder GridHolder">
                <asp:GridView ID="GridView1" Class="ContentTable" runat="server" AutoGenerateColumns="False" DataSourceID="JTMProduct" AllowSorting="True" DataKeyNames="productid">
                    <Columns>
                        <asp:BoundField DataField="productname" HeaderText="Produktsnavn" SortExpression="productname" />
                        <asp:BoundField DataField="amount" HeaderText="Mængde" SortExpression="amount" />                            
                        <asp:BoundField DataField="price" HeaderText="Pris" SortExpression="price" />                           
                        <asp:BoundField DataField="info" HeaderText="Information" SortExpression="info" />
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True">
                            <ControlStyle Width="70px" />
                            <HeaderStyle Width="160px" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="JTMProduct" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [productinfo]" DeleteCommand="DELETE FROM [productinfo] WHERE [productid] = @productid" InsertCommand="INSERT INTO [productinfo] ([productname], [amount], [price], [info]) VALUES (@productname, @amount, @price, @info)" UpdateCommand="UPDATE [productinfo] SET [productname] = @productname, [amount] = @amount, [price] = @price, [info] = @info WHERE [productid] = @productid">
                    <DeleteParameters>
                        <asp:Parameter Name="productid" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="productname" Type="String" />
                        <asp:Parameter Name="amount" Type="Double" />
                        <asp:Parameter Name="price" Type="Double" />
                        <asp:Parameter Name="info" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="productname" Type="String" />
                        <asp:Parameter Name="amount" Type="Double" />
                        <asp:Parameter Name="price" Type="Double" />
                        <asp:Parameter Name="info" Type="String" />
                        <asp:Parameter Name="productid" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>
