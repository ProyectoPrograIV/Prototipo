<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../HojasdeEstilos/EstiloMenu.css" rel="stylesheet" type="text/css" />
   
    </head>
<body>
    <form runat="server">
    <div class="div">
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="width:15%">
                        <asp:Menu ID="Opciones" runat="server" Orientation="Vertical" CssClass="Menu" BorderColor="Black" BorderStyle="None" ForeColor="Black" Height="50%" OnMenuItemClick="Opciones_MenuItemClick">
                            <DynamicHoverStyle BackColor="#F0776C" />
                            <DynamicMenuItemStyle VerticalPadding="10px" HorizontalPadding="4px"/>
                            <DynamicMenuStyle BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                            <Items>
                                <asp:MenuItem Text="Parametrizaciones" Value="Parametrizaciones" ImageUrl="~/Archivos/Recursos/Parametros.png">
                                    <asp:MenuItem Text="Tarifas de Autobus" Value="Tarifas de Autobus"></asp:MenuItem>
                                    <asp:MenuItem Text="Tarifas de Viaticos" Value="Tarifas de Viaticos"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Solicitud de Viaticos" Value="Solicitud de Viaticos" ImageUrl="~/Archivos/Recursos/Solicitud.png">
                                    <asp:MenuItem Text="Creacion" Value="CreacionSolicitud" ImageUrl="~/Archivos/Recursos/Nuevo.png"></asp:MenuItem>
                                    <asp:MenuItem Text="Consulta" Value="ConsultaSolicitud"></asp:MenuItem>
                                    <asp:MenuItem Text="Actualizacion" Value="ActualizacionSolicitud"></asp:MenuItem>
                                    <asp:MenuItem Text="Verificacion" Value="VerificacionSolicitud"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Orden de Viaticos" Value="Orden de Viaticos" ImageUrl="~/Archivos/Recursos/Orden.png">
                                    <asp:MenuItem Text="Generacion" Value="Generacion"></asp:MenuItem>
                                    <asp:MenuItem Text="Consulta" Value="ConsultaOrden"></asp:MenuItem>
                                    <asp:MenuItem Text="Actualizacion" Value="ActualizacionOrden"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Liquidacion de Viaticos" Value="Liquidacion de Viaticos" ImageUrl="~/Archivos/Recursos/Liquidacion.png">
                                    <asp:MenuItem Text="Creacion" Value="CreacionLiquidacion"></asp:MenuItem>
                                    <asp:MenuItem Text="Consulta" Value="ConsultaLiquidacion"></asp:MenuItem>
                                    <asp:MenuItem Text="Actualizacion" Value="ActualizacionLiquidacion"></asp:MenuItem>
                                    <asp:MenuItem Text="Verificacion" Value="VerificacionLiquidacion"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Reportes" Value="Reportes" ImageUrl="~/Archivos/Recursos/Reportes.png" NavigateUrl="~/Archivos/WebForms/Ingreso.aspx"></asp:MenuItem>
                                <asp:MenuItem ImageUrl="~/Archivos/Recursos/Usuario.png" Text="Usuarios" Value="Usuarios"></asp:MenuItem>
                            </Items>
                            <StaticHoverStyle BackColor="White" BorderStyle="Solid" BorderWidth="1px" />
                            <StaticMenuItemStyle VerticalPadding="10px" HorizontalPadding="4px"/>
                        </asp:Menu>
                    </td>
                    <td style="width:85%">
                        <iframe id="WebFormViewer" runat="server" width="1270" height="950" style="border-style:none"></iframe>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
