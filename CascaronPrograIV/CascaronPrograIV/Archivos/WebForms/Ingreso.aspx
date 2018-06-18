<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="~/Archivos/HojasdeEstilos/EstiloLogin.css" type="text/css" rel="stylesheet" id="EstiloLogin" /> 
<title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body class="body">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <form class="login" runat="server">
        <h1 class="login-title">Ingreso a PK2</h1>
        <div class="auto-style1">
        <asp:TextBox CssClass="login-input" ID="TbxUsuario" runat="server"></asp:TextBox>
        <asp:TextBox CssClass="login-input" ID="TbxPassword" runat="server"></asp:TextBox>
        <asp:Button CssClass="login-button" ID="BtnIngresar" runat="server" Text="Ingresar" />
            <br />
            <br />
        <asp:Label CssClass="login-lost" ID="LblRegistrarse" runat="server" Text="Registrar Usuario" ForeColor="Black"></asp:Label>
            <br />
            <br />
        <asp:Label CssClass="login-lost" ID="LblRecuperacion" runat="server" Text="Recuparar Datos de Ingreso" ForeColor="Black"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
