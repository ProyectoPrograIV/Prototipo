<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParametroAutobus.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Parametrizaciones.ParametroAutobus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../HojasdeEstilos/Parametrizaciones/EstiloParamAutoBus.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divOpcion" style="width: 1050px;">
            <h1>Ingreso de Nueva Tarifa</h1>
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" Text="Codigo de Ruta" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" Text="Codigo de Provincia" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" Text="Tarifa" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox4" runat="server" Text="Fecha de Vigencia" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox5" runat="server" Text="Descripcion" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox6" runat="server" Text="Estado" onclick="this.value=''"></asp:TextBox>
            <br />
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        </div>
        <div class="divGrid">
        <asp:GridView ID="Gv_TarifaAutobus" runat="server" CellPadding="3" Width="100%" Height="300px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
            <Columns>
                <asp:BoundField HeaderText="Codigo de Ruta">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Codigo de Provincia">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Tarifa">
                <HeaderStyle Width="15%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Fecha de Vigencia">
                <HeaderStyle Width="20%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Descripcion">
                <HeaderStyle Width="35%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Estado">
                <HeaderStyle Width="10%" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Height="90px" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </div>
    </form>
</body>
</html>
