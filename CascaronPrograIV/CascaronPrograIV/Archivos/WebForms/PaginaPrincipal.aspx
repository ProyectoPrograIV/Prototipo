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
    <form id="form1" runat="server">

        <div style="text-align: center;">
            <h1>Pagina Principal</h1>
            <br />

            <br />

            <table style="text-align: center;">

                <tr>
                    <td  style="width: 20%">
                        <asp:Label runat="server">Crear Solicitud de Viaticos</asp:Label>
                    </td>
                    <td  style="width: 20%">
                        <asp:button  runat="server" Text="Crear Solicitud Viaticos" Width="100%"></asp:button>
                    </td>
                    <td style="width: 20%"

                    </td>
                     <td  style="width: 20%">
                        <asp:Label runat="server">Crear Solicitud de Viaticos</asp:Label>
                    </td>
                    <td  style="width: 20%">
                        <asp:button  runat="server" Text="Crear Solicitud Viaticos" Width="100%"></asp:button>
                    </td>
                  
                </tr>

                 <tr>

                    <td  style="width: 20%">
                        <asp:Label runat="server">Consultar Solicitud de Viaticos</asp:Label>
                    </td>
                    <td  style="width: 20%">
                        <asp:button  runat="server" Text="Consultar Solicitud Viaticos"  Width="100%"></asp:button>
                    </td>
                  
                </tr>

                <!--
                <tr>
                    <td>

                        <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" Text="Iniciar sesión" />
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblAvisos" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label></td>
                </tr>
                -->



            </table>
        </div>
    </form>
</body>
</html>
