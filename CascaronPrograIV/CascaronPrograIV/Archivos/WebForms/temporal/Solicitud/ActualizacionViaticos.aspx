<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizacionViaticos.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.ActualizacionViaticos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../HojasdeEstilos/Solicitud/EstiloActualizacion.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Actualizar Solicitud de Viaticos</h1>
        <div class="divGrid">
            <asp:GridView CssClass="DataGrid" ID="Gv_Actualizacion" runat="server" CellPadding="4" ForeColor="#333333" GridLines="Both" HeaderStyle-Height="50px" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
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
        <div style="border:double 5px" >
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" Text="Nombre de Usuario"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" Text="Fecha de Creacion"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" Text="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server" Text="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server" Text="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server" Text="Destino"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox7" runat="server" Text="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox8" runat="server" Text="Hora de Regreso"></asp:TextBox>
            <asp:Button CssClass="button" ID="Btn_Actualizar" runat="server" Text="Actualizar" OnClick="Btn_Actualizar_Click" />
        </div>
    </form>
</body>
</html>
