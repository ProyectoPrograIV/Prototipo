<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Liquidacion.Creacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../HojasdeEstilos/Liquidacion/EstiloCreacion.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Crear Liquidacion de Viaticos</h1>
        </div>
        <div>
            <asp:TextBox CssClass="textbox" ID="TbxFecha" runat="server" Text="Fecha de Liquidacion"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxMontoDesayuno" runat="server" Text="Monto de Dasayuno"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxMontoAlmuerzo" runat="server" Text="Monto de Almuerzo"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxMontoCena" runat="server" Text="Monto de Cena"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxMontoHospedaje" runat="server" Text="Monto de Hospedaje"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxMontoPasaje" runat="server" Text="Monto de Pasaje"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TbxEstado" runat="server" Text="Estado"></asp:TextBox>
        </div>
        <div>
            <asp:Button CssClass="button" ID="BtnGuardar" runat="server" Text="Guardar" />
        </div>
    </form>
</body>
</html>
