<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParametroViaticos.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Parametrizaciones.ParametroViaticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../HojasdeEstilos/Parametrizaciones/EstiloParamViaticos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="divOpcion">
            <h1>Agregar Nuevo Tipo de Viatico</h1>
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" Text="Tipo Tarifa"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" Text="Monto de tarifa"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" Text="Fecha de Tarifa"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server" Text="Localidad"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server" Text="Provincia"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server" Text="Canton"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server" Text="Estado"></asp:TextBox>
            <br />
            <asp:Button CssClass="button" ID="Btn_Guardar" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click" />
        </div>
        <div class="divGrid">
            <asp:GridView CssClass="DataGrid" ID="Gv_ModViaticos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" HeaderStyle-Height="50px" ShowHeaderWhenEmpty="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="Tipo de Tarifa" />
                    <asp:BoundField HeaderText="Monto de Tarifa" />
                    <asp:BoundField HeaderText="Fecha de Tarifa" />
                    <asp:BoundField HeaderText="Localidad" />
                    <asp:BoundField HeaderText="Provincia" />
                    <asp:BoundField HeaderText="Canton" />
                    <asp:BoundField HeaderText="Estado" />
                </Columns>
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
    </form>
</body>
</html>
