<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BackOfficeWebUI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BACKOFFICE</title>
</head>
<body>
     <div id="header">
        <h1>TEST NOTICIAS BACKOFFICE</h1>
    </div>
    <form id="form1" runat="server">
        <div class="button-container">
            <p>
                <asp:Button ID="Button_Insertar" runat="server" OnClick="Button_Insertar_Click" Text="Insertar Noticia" CssClass="custom-button" />
            </p>
            <p>
                <asp:Button ID="Button_Listar" runat="server" Text="Listar Noticias (Angular)" OnClick="Button_Listar_Click" CssClass="custom-button"/>
            </p>
        </div>
    </form>
</body>
</html>
