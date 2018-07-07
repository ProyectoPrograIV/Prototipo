<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../HojasdeEstilos/EstiloMenu.css" rel="stylesheet" type="text/css" />

    <script src="jquery-3.3.1.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#btnToggleMenu").click(function () {
                $("#Opciones").toggle("fast", "swing");
                //  alert("wtf dude");
            });
        });
    </script>
</head>
<body>
    <form runat="server" class="formMenu">
        <div class="divMenu">
            <asp:ImageButton CssClass="Imagen" ToolTip="Esconder/Mostrar Menú " ID="btnToggleMenu" runat="server" ImageUrl="~\Archivos\Recursos\menutoggle.png" Width="40px" Height="40px" OnClick="btnToggleMenu_Click" />
            <asp:Menu ID="Opciones" runat="server" Orientation="Vertical" CssClass="Menu" BorderColor="Black" BorderStyle="None" ForeColor="Black" Height="50%" OnMenuItemClick="Opciones_MenuItemClick">
                <DynamicHoverStyle BackColor="#F0776C" />
                <DynamicMenuItemStyle VerticalPadding="10px" HorizontalPadding="4px" />
                <DynamicMenuStyle BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                <Items>
                    <asp:MenuItem Text="Parametrizaciones" Value="Parametrizaciones" ImageUrl="~/Archivos/Recursos/Parametros.png">
                        <asp:MenuItem Text="Tarifas de Autobus" Value="Tarifas de Autobus"></asp:MenuItem>
                        <asp:MenuItem Text="Tarifas de Viaticos" Value="Tarifas de Viaticos"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Solicitud de Viaticos" Value="Solicitud de Viaticos" ImageUrl="~/Archivos/Recursos/Solicitud.png">
                        <asp:MenuItem Text="Creacion" Value="CreacionSolicitud"></asp:MenuItem>
                        <asp:MenuItem Text="Consulta" Value="ConsultaSolicitud"></asp:MenuItem>
                        <asp:MenuItem Text="Actualizacion" Value="ActualizacionSolicitud"></asp:MenuItem>
                        <asp:MenuItem Text="Verificacion" Value="VerificacionSolicitud"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Orden de Viaticos" Value="Orden de Viaticos" ImageUrl="~/Archivos/Recursos/Orden.png">
                        <asp:MenuItem Text="Generacion" Value="GeneracionOrden"></asp:MenuItem>
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
                <StaticMenuItemStyle VerticalPadding="10px" HorizontalPadding="4px" />
            </asp:Menu>
        </div>
        <div class="divFrame">
            <iframe id="WebFormViewer" runat="server" class="iframe"></iframe>
        </div>
    </form>
</body>
</html>
