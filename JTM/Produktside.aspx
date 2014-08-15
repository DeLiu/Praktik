<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Produktside.aspx.cs" Inherits="Produktside" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h3>Velkommen til vores podukt side, vis nogle af vores produkter har interrese kan du kontakte JTM. du kan finde vores kontakt information ved at trykke på kontakt tabben.<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductDBString %>" SelectCommand="SELECT * FROM [productinfo]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="graintype" HeaderText="graintype" SortExpression="graintype" />
                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="infomation" HeaderText="infomation" SortExpression="infomation" />
            </Columns>
        </asp:GridView>
    </h3>
</asp:Content>

