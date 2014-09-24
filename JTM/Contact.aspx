<%@ Page Title="Contact" Language="C#" MasterPageFile="~/MasterPage/Site.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kontakt JTM-Landbrug</h2>
    <h3>Hvis du ønsker at kontakte JTM-Landbrug, kan du benytte følgende oplysninger nedenfor:</h3>
    <address runat="server" id="emailaddressBox">
        <!--TODO: måske nogle rigtige adresser til salg osv, som f.eks. salg@jtm-landbrug.dk og partner@jtm-landbrug.dk -->
        <strong>Salg:</strong>   <a href="mailto:test@testtesttest.com">test@testtesttest.com</a><br />
    </address>
    <address runat="server" id="addressBox">
        Saksmosevej 15<br />
        7300, Jelling<br />
        <abbr title="Telefon">Tlf:</abbr>
        71201113
    </address>
</asp:Content>
