
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forum/ForumSiteMaster.master" CodeFile="Category.aspx.cs" Inherits="Forum_Topic" %>


<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <form id="form1" runat="server">
    <div>
        <input type="text" id="username" runat="server" placeholder="Brugernavn" />
        <input type="password" id="password" runat="server" placeholder="Password" />
        
        <asp:Button ID="loginbt" runat="server" Text="Login" />
        
    </div>
    </form>
</asp:Content>