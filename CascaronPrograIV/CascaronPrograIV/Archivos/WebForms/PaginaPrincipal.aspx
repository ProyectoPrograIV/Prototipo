<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="~/Archivos/HojasdeEstilos/EstiloLogin.css" type="text/css" rel="stylesheet" id="EstiloLogin" />
    -->
    <title>Pagina Principal</title>

</head>
<body>
    <form id="frmPaginaPrincipal" runat="server">

        <br />
        <br />
        <br />
        <div style="text-align: center;">
            <h1>Pagina Principal</h1>
            <br />

            <br />

            <!-- Se inicia el bloque que correspondería a los funcionarios -->
            <div id="divFuncionarios" title="Para perfil de funcionario" style="border: groove; background-color:antiquewhite" runat="server">
                <br />

                <!-- Se inicia la tabla -->
                <table style="text-align: center; width: 100%;">

                    <!-- Se inicia Una nueva fila -->
                    <tr>

                        <!-- Se colocan columnas -->
                        <td style="width: 5%"></td>
                        <td style="width: 20%">
                            <asp:Label runat="server">Crear Solicitud de Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Crear Solicitud Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 10%"></td>

                        <td style="width: 20%">
                            <asp:Label runat="server">Consulta Solicitud de Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Consulta Solicitud Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 5%"></td>
                    </tr>
                    <!-- Final de fila -->


                    <!-- Se inicia una nueva fila -->
                    <tr>

                        <!-- Se colocan columnas -->
                        <td style="width: 5%"></td>

                        <td style="width: 20%">
                            <asp:Label runat="server">Actualizar Solicitud de Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Actualizar Solicitud Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 10%"></td>

                        <td style="width: 20%">
                            <asp:Label runat="server">Consulta Liquidacion de Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Consulta Liquidacion Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 5%"></td>
                    </tr>
                    <!-- Final de fila -->

                    <!-- Se inicia una nueva fila -->
                    <tr>

                        <!-- Se colocan columnas -->
                        <td style="width: 5%"></td>

                        <td style="width: 20%">
                            <asp:Label runat="server">Liquidar Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Liquidar Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 10%"></td>

                        <td style="width: 20%">
                            <asp:Label runat="server">Actualizar Liquidación de Viaticos</asp:Label>
                        </td>
                        <td style="width: 20%">
                            <asp:Button runat="server" Text="Actualizar Liquidación Viaticos" Width="100%" Height="100%"></asp:Button>
                        </td>

                        <td style="width: 5%"></td>
                    </tr>
                    <!-- Final de fila -->



                </table>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
