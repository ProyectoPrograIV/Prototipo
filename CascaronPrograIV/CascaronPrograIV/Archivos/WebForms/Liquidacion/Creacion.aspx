<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Liquidacion.Creacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../HojasdeEstilos/EstiloRegistro.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Liquidar viáticos</h1>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <p>Fecha liquidación (hoy)</p>
                    </td>
                    <td>
                        <asp:TextBox ID="txt1" runat="server" TextMode="Date" placeholder="Fecha Liquidación (Hoy)"></asp:TextBox>
                    </td>
                    
                    <td>
                  <asp:DropDownList ID="ddlSolicitudesActivas" runat="server">
                      <asp:ListItem>SolicitudActiva 1</asp:ListItem>
                      <asp:ListItem>SolicitudActiva 2</asp:ListItem>
                      <asp:ListItem>SolicitudActiva 3</asp:ListItem>
                  </asp:DropDownList>
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Monto Entregado" Enabled="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Monto Gastado"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Cantidad Devolución" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="btnCrearLiquidación" runat="server" Text="Crear Liquidación" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
