<%@ Page Title="" Language="C#" MasterPageFile="~/Forum/ForumSiteMaster.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Forum_SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <form id="form1" runat="server">
    <div id="content" runat="server">
       <asp:Label ID="lblFejl" runat="server" ForeColor="Red"></asp:Label>
        <table style="width:325px">
        <tr>
        <td><asp:Label ID="Label1" runat="server" Text="Brugernavn:"></asp:Label></td><td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label2" runat="server" Text="Adgangskode:"></asp:Label></td><td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label3" runat="server" Text="Bekræft adgangskode:"></asp:Label></td><td><asp:TextBox ID="txtConfPass" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="Label4" runat="server" Text="E-mail:"></asp:Label></td><td><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Button ID="btnOpret" runat="server" OnClick="btnOpret_Click" Text="Opret bruger"></asp:Button></td>
        </tr>
        </table>
        </div>
    </form>
</asp:Content>

