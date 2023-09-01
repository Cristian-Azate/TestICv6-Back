<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar Noticia.aspx.cs" Inherits="BackOfficeWebUI.Insertar_Noticia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Insertar Noticia</title>
</head>
<body>
    <form id="form" runat="server" aria-expanded="false" aria-grabbed="undefined">
        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
        <!-- Aquí van los controles de tu formulario -->
        </ContentTemplate>
        </asp:UpdatePanel>
        <h2>Datos Noticia</h2>
     
        <asp:Label ID="Label" runat="server"> <span class="red-text">*</span>Indica campo obligatorio</asp:Label>
        <br />
        <br />    
        <asp:Label ID="LabelTitulo" runat="server"> Titulo Noticia<span class="red-text">*</span></asp:Label>
        <asp:TextBox ID="TextBox_Titulo" runat="server" CssClass="custom-textbox" AutoCompleteType="Disabled"></asp:TextBox>
        <br />   
         <asp:Label ID="LabelCuerpo" runat="server"> Cuerpo Noticia<span class="red-text">*</span></asp:Label>
        <br />
        <textarea id="TextArea_Cuerpo" runat="server" aria-expanded="false"></textarea>
        <br />
       <asp:Label ID="LabelFecha" runat="server">Fecha Noticia </asp:Label>
        <asp:Calendar ID="Calendario" runat="server" CssClass="custom-calendar" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>   
       
        Imagen(opcional)
        <br />
        <br />
        <asp:FileUpload ID="FileUploadImage" runat="server" accept=".jpg"  CssClass="custom-fileupload"/>
        <br />
        <asp:Button ID="ButtonVisualizar" runat="server" OnClick="Visualizar_Click" Text="Visualizar Imagen" CssClass="custom-button"/>
        <asp:Image ID="ImagePreview" runat="server" CssClass="custom-image"/>
        <div class="button-container">
            <asp:Button ID="Button_Insertar" runat="server" Text="Insertar Noticia" CssClass="custom-confirm-button" OnClick="Button_Insertar_Click" />
        </div>
    </form>
</body>
</html>
