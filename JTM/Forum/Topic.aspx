<%@ Page Title="" Language="C#" MasterPageFile="~/Forum/ForumSiteMaster.master" AutoEventWireup="true" CodeFile="Topic.aspx.cs" Inherits="Forum_Topic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form1" runat="server">
    <div id="content" runat="server">
        
    </div>
    <div>
        <textarea id="reply" runat="server"></textarea>
        
        <br />
        
    </div>
        <asp:Button ID="Button1" runat="server" Text="Indsend indlæg" OnClick="Button1_Click" />
    </form>
</asp:Content>

