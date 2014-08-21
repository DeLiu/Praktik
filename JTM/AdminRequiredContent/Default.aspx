<%@ Page Language="C#" Title="Index" MasterPageFile="~/AdminRequiredContent/CMS.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="AdminRequiredContent_Default" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="head">
    </asp:Content>
<asp:Content ID="bodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div aria-orientation="vertical">
    
        <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <Items>
                <asp:MenuItem NavigateUrl="~/AdminRequiredContent/Default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/AdminRequiredContent/EditProfilePage.aspx" Text="Edit Profile" Value="Edit Profile"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/AdminRequiredContent/EditProductPage.aspx" Text="Edit Product" Value="Edit Product"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/AdminRequiredContent/EditLinks.aspx" Text="Edit Links" Value="Edit Links"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#507CD1" />
        </asp:Menu>
    </div>
</asp:Content>