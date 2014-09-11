<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forum/ForumSiteMaster.master" CodeFile="Login.aspx.cs" Inherits="Forum_Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form1" runat="server">
    <div>
        <input type="text" id="username" runat="server" />
        <input type="password" id="password" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    </div>
        <div id="content" runat="server"></div>
    </form>
</asp:Content>
