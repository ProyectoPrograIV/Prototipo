<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerificacionSolicitud.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.VerificacionSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../HojasdeEstilos/Solicitud/EstiloVerificacion.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Verificacion de Solicitudes de Viaticos</h1>
        </div>
        <div>
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Buscar" />
        </div>
    <div>
        <asp:GridView CssClass="DataGrid" ID="GvVerificacion" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" Height="300px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="1" />
                <asp:BoundField HeaderText="2" />
                <asp:BoundField HeaderText="3" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="50px" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
        <div class="divbuttons">
            <asp:Button CssClass="button" ID="BtnDenegar" runat="server" Text="Denegar" />
            <asp:Button CssClass="button" ID="BtnAprobar" runat="server" Text="Aprobrar" OnClick="BtnAprobar_Click" />
        </div>
    </form>
</body>
</html>
