<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="Forum_MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forum</title>
    <link href="Forum.css" rel="stylesheet" type ="text/css" />
</head>
<body>
        <header><h3>Velkommen til forumet</h3></header>
        <nav>
            <ul>
                <li><a href="Generel%20Diskusion.aspx">Generel Diskusion</a></li>
                <li><a href="Økologi%20og%20Landbrug.aspx">Økologi og Landbrug</a></li>
            </ul>
        </nav>
    <section>

    </section>
   <footer><p>&copy; <%: DateTime.Now.Year %> - JTM-Landbrug</p></footer>
   
</body>
</html>
