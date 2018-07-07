﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verificacion.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Liquidacion.Verificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../HojasdeEstilos/Liquidacion/EstiloVerificacion.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Verificacion de liquidaciones de Viaticos</h1>
    </div>
        <div>
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Buscar" />
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
            <asp:Button CssClass="button" ID="Button3" runat="server" Text="Rechazar" />
            <asp:Button CssClass="button" ID="Button2" runat="server" Text="Aceptar" />
        </div>
    </form>
</body>
</html>
