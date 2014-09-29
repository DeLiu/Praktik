<%@ Page Title="" Language="C#" MasterPageFile="~/Forum/ForumSiteMaster.master" AutoEventWireup="true" CodeFile="Create_Topic.aspx.cs" Inherits="Forum_Create_Topic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form1" runat="server">
    <div id="content" runat="server">
        <h2>Opret en tråd</h2>
        <p>Emne:
            <asp:TextBox ID="txtEmne" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtContent" runat="server" Height="167px" Width="399px" TextMode="MultiLine">Trådens indhold her.</asp:TextBox>
&nbsp;</p>
        <p>
            <asp:Button ID="btnOpret" runat="server" OnClick="btnOpret_Click" Text="Opret tråd" />
&nbsp;<asp:SqlDataSource ID="forumDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ForumConnectionString %>" SelectCommand="SELECT [cat_name] FROM [categories]"></asp:SqlDataSource>
        </p>
    </div>
    </form>
</asp:Content>

