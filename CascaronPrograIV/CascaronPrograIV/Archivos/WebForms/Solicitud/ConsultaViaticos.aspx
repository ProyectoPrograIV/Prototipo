<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaViaticos.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.ConsultaViaticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../HojasdeEstilos/Solicitud/EstiloConsulta.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consulta de Estado de Solicitud de Viaticos</h1>
        </div>
        <div>
            <asp:GridView CssClass="DataGrid" ID="Gv_ConsultaSolicitud" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" HeaderStyle-Height="50px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="1" HeaderStyle-Height="50px"/>
                    <asp:BoundField HeaderText="2" HeaderStyle-Height="50px"/>
                    <asp:BoundField HeaderText="3" HeaderStyle-Height="50px"/>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
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
