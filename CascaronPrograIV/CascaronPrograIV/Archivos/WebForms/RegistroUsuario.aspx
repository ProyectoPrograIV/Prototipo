<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Colaboradores</title>
    <link href="../HojasdeEstilos/EstiloRegistro.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style3 {
            border-style: none;
            border-color: inherit;
            border-width: 0;
            width: 250px;
            height: 50px;
            padding: 0;
            font-size: 20px;
            color: #fff;
            text-align: center;
            background: #f0776c;
            border-radius: 5px;
            cursor: pointer;
            outline: 0;
            margin-left: 106px;
        }
    </style>
</head>
<body>
    <br />
    <br />
    <br />
    <form class="form" id="form1" runat="server">
        <br />
        <h1 class="regist-title">REGISTRAR NUEVO COLABORADOR</h1>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Tbx_Apellidos" Display="Dynamic" ErrorMessage="Ingresar Apellidos">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TbxNombre" Display="Dynamic" ErrorMessage="Ingrese Nombre">*</asp:RequiredFieldValidator>
        <asp:TextBox CssClass="BtnLeft" placeholder="Nombre" ID="TbxNombre" runat="server"></asp:TextBox>
        <asp:TextBox CssClass="BtnRight" placeholder="Apellidos" ID="Tbx_Apellidos" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Tbx_Identificacion" ErrorMessage="ingrese Identificacion">*</asp:RequiredFieldValidator>
        <asp:TextBox CssClass="BtnRight" placeholder="Identificacion" ID="Tbx_Identificacion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Tbx_Cod_Rol" ErrorMessage="Ingrese Cod Rol">*</asp:RequiredFieldValidator>
        <asp:TextBox CssClass="BtnLeft" placeholder="Codigo Rol" ID="Tbx_Cod_Rol" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Tbx_Usuario" Display="Dynamic" ErrorMessage="Ingrese Usuario">*</asp:RequiredFieldValidator>
        <asp:TextBox CssClass="BtnLeft" placeholder="Usuario" ID="Tbx_Usuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Tbx_Password" Display="Dynamic" ErrorMessage="Ingrese Clave">*</asp:RequiredFieldValidator>
        <asp:TextBox CssClass="BtnRight" placeholder="Contraseña" ID="Tbx_Password" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Tbx_Email" Display="Dynamic" ErrorMessage="Ingrese Correo">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Tbx_Password" Display="Dynamic" ErrorMessage="Clave Mayor a 8 Caracteres" ValidationExpression="^\w{8,}">*</asp:RegularExpressionValidator>
        <asp:TextBox CssClass="BtnCenter" placeholder="Correo Electronico" ID="Tbx_Email" runat="server"></asp:TextBox>
        <br />
        <asp:Button CssClass="Regresar-button" ID="BtnRegresar" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" />
        <asp:Button CssClass="auto-style3" ID="BtnGuardar" runat="server" Text="Guardar Colaborador" OnClick="BtnGuardar_Click" />
    </form>
</body>
</html>
