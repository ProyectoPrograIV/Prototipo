<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="~/Archivos/HojasdeEstilos/EstiloLogin.css" type="text/css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form class="login" runat="server">
        <h1 class="login-title">Ingreso a PK2</h1>
        <div>
            <asp:RequiredFieldValidator ID="ValNom" runat="server" ControlToValidate="TbxUsuario" Display="Dynamic" ErrorMessage="Ingrese Datos" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:TextBox CssClass="login-input" ID="TbxUsuario" runat="server" Placeholder="Usuario"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValClave" runat="server" ControlToValidate="TbxPassword" Display="Dynamic" ErrorMessage="Ingrese Clave" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:TextBox CssClass="login-input" ID="TbxPassword" runat="server" Placeholder="Password" TextMode="Password"></asp:TextBox>
            <asp:Button CssClass="login-button" ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
            <div>
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LbtnRecuperar_Click">Recuperar Datos de Ingreso</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
