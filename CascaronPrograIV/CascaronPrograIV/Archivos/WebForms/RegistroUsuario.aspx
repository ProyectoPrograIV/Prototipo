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
    <form class="form" id="form1" runat="server">
        <br />
        <h1 class="regist-title">REGISTRAR NUEVO COLABORADOR</h1>
        <br />
        <asp:TextBox CssClass="BtnLeft" ID="TbxNombre" runat="server" Text="Nombre" OnClick="this.value=''"></asp:TextBox>
        <asp:TextBox CssClass="BtnRight" ID="TextBox2" runat="server" Text="Apellidos" OnClick="this.value=''"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="BtnLeft" ID="TextBox3" runat="server" Text="Tipo de identificacion" OnClick="this.value=''"></asp:TextBox>
        <asp:TextBox CssClass="BtnRight" ID="TextBox4" runat="server" Text="Identificacions" OnClick="this.value=''"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="BtnLeft" ID="TextBox5" runat="server" Text="Usuario" OnClick="this.value=''"></asp:TextBox>
        <asp:TextBox CssClass="BtnRight" ID="TextBox6" runat="server" Text="Contraseña" OnClick="this.value=''"></asp:TextBox>
        <br />
        <asp:TextBox CssClass="BtnCenter" ID="TextBox1" runat="server" Text="Correo Electronico" OnClick="this.value=''"></asp:TextBox>
        <br />
        <asp:Button CssClass="Regresar-button" ID="BtnRegresar" runat="server" Text="Regresar" OnClick="BtnRegresar_Click" />
        <asp:Button CssClass="auto-style3" ID="BtnGuardar" runat="server" Text="Guardar Colaborador" OnClick="BtnGuardar_Click" />
    </form>
</body>
</html>
