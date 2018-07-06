<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreacionViaticos.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.CreacionViaticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../HojasdeEstilos/Solicitud/EstiloCreacionSolicitud.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="divInfo">
            <h1>Crear Solicitud de Viaticos</h1>
        </div>
        <div>
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" Text="Nombre de Usuario"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" Text="Fecha de Creacion"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" Text="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server" Text="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server" Text="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server" Text="Destino"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server" Text="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server" Text="Hora de Regreso"></asp:TextBox>
        </div>
        <div class="divButton">
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Crear" />
        </div>
    </form>
</body>
</html>
