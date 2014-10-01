<%@ Page Title="" Language="C#" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="Statistik.aspx.cs" Inherits="AdminRequiredContent_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="content" runat="server">
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlGetIP">
        <Columns>
            <asp:BoundField DataField="browser" HeaderText="Browser" SortExpression="browser" />
            <asp:BoundField DataField="browserv" HeaderText="Version" SortExpression="browserv" />
            <asp:BoundField DataField="browserp" HeaderText="Platform" SortExpression="browserp" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlGetIP" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [browser], [browserv], [browserp] FROM [ips]"></asp:SqlDataSource>
    <br />
    <asp:Button ID="btnRyd" runat="server" Height="20px" OnClick="btnRyd_Click" style="margin-bottom: 0px" Text="Ryd data" />
</asp:Content>

