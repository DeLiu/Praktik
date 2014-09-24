<%@ Page Language="C#" MasterPageFile="~/Forum/ForumSiteMaster.master" AutoEventWireup="true" CodeFile="Create_Cat.aspx.cs" Inherits="Forum_Create_Cat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form1" runat="server">
    <div id="content" runat="server">
        <input id="subname" runat="server" type="text" placeholder="Indtast subforum navn" />
        <input id="subdesc" runat="server" type="text" placeholder="Indtast subforum beskrivelse" />
        
        <asp:Button ID="CreateSubBtn" runat="server" OnClick="CreateSubBtn_Click" Text="Opret" />
        
    </div>
    </form>
</asp:Content>

