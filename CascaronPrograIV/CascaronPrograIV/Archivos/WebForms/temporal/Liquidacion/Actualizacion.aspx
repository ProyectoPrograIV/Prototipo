<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Liquidacion.Actualizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../HojasdeEstilos/Liquidacion/EstiloActualizacion.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Actualizacion de Liquidacion</h1>
    </div>
        <div class="divGrid">
            <asp:GridView CssClass="DataGrid" ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
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
            <asp:Button CssClass="button" ID="BtnActualizar" runat="server" Text="Actualizar" />
        </div>
    </form>
</body>
</html>
