<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreacionSolicitud.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.CreacionSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../HojasdeEstilos/Parametrizaciones/EstiloParamAutoBus.css" rel="stylesheet" type="text/css" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Creacion de Usuarios</h1>
        <div class="divOpcion">
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" placeholder="ID Solicitud" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" placeholder="Fecha de salida" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" placeholder="Fecha de regreso" Enabled="false" onclick="this.value=''"></asp:TextBox>

            <div class="divOpcion">
                <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server" placeholder="Fecha y hora actual" Enabled="false" onclick="this.value=''"></asp:TextBox>
                <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server" placeholder="Hora de Salida" onclick="this.value=''"></asp:TextBox>
                <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server" placeholder="Hora de Regreso" onclick="this.value=''"></asp:TextBox>

                <div class="divOpcion">
                    <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server" placeholder="Nombre Usuario" onclick="this.value=''"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server" placeholder="Justificacion" onclick="this.value=''"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="TextBox9" runat="server" placeholder="Destino" onclick="this.value=''"></asp:TextBox>
                    <asp:Button CssClass="button" ID="Button3" runat="server" Text="Crear Solicitud" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
