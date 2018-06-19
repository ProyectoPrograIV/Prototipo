<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="~/Archivos/HojasdeEstilos/EstiloLogin.css" type="text/css" rel="stylesheet"/> 
<title></title>
</head>
<body>
    <form class="login" runat="server">
        <h1 class="login-title">Ingreso a PK2</h1>
        <div>
            <asp:TextBox CssClass="login-input" ID="TbxUsuario" runat="server" Text="Usuario" OnClick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="login-input" ID="TbxPassword" runat="server" Text="Contraseña" OnClick="this.value=''"></asp:TextBox>
            <asp:Button CssClass="login-button" ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
            <div>
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LbtnRecuperar_Click">Recuparar Datos de Ingreso</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
