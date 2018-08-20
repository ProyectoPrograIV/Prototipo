<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarDatos.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.RecuperarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../HojasdeEstilos/EstiloRecuperar.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <div class="div">
                <asp:Label CssClass="label" Text="Recuperar Datos de Ingreso" runat="server" />
                <br />
                <br />
            </div>
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TbxNumeroIdentificacion" Display="Dynamic" ErrorMessage="Ingrese Identificacion" ForeColor="Black">*</asp:RequiredFieldValidator>
            <asp:TextBox CssClass="TextBox" ID="TbxNumeroIdentificacion" runat="server" Text="Numero de Identificacion" OnClick="this.value=''"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox CssClass="TextBox" ID="TbxNombreCompleto" runat="server" Text="Nombre Completo" OnClick="this.value=''"></asp:TextBox>
            <br />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TbxCorreo" Display="Dynamic" ErrorMessage="Ingrese Correo" ForeColor="Black">*</asp:RequiredFieldValidator>
            <asp:TextBox CssClass="TextBox" ID="TbxCorreo" runat="server" Text="Correo Electronico" OnClick="this.value=''"></asp:TextBox>
            <br />
            <br />
            <asp:Button CssClass="button" ID="BtnRegresar" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" />
            <asp:Button CssClass="button" ID="BtnRecuperar" runat="server" Text="Recuperar" OnClick="BtnRecuperar_Click" />
        </div>
    </form>
</body>
</html>
