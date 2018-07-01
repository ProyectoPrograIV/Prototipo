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
        <div class="divOpcion">
            <asp:TextBox CssClass="textbox" ID="TextBox1" runat="server" Text="Fraccionamiento" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox2" runat="server" Text="Tarifa Normal" onclick="this.value=''"></asp:TextBox>
            <asp:TextBox CssClass="textbox" ID="TextBox3" runat="server" Text="Operador" onclick="this.value=''"></asp:TextBox>
            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Agregar" />
        </div>
        <div class="divGrid">
        <asp:GridView ID="GridView1" runat="server" CellPadding="3" Width="100%" Height="100%" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:BoundField HeaderText="Fraccionamiento" ItemStyle-Width="45%" />
                <asp:BoundField HeaderText="Tarifa Normal" ItemStyle-Width="10%" />
                <asp:BoundField HeaderText="Operador" ItemStyle-Width="45%" />
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
