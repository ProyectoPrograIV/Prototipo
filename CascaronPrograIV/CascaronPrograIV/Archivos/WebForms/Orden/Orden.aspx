<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Orden.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Orden.Orden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            border-style: none;
            border-color: inherit;
            border-width: 0;
            padding: 0;
            font-size: 20px;
            color: #fff;
            text-align: center;
            background: #2d343d;
            border-radius: 5px;
            cursor: pointer;
            outline: 0;
            margin-left: 0px;
        }

        .auto-style5 {
            margin: 20px 0px;
            text-align: center;
            color: #ADADAD;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: 900;
            font-size: 22px;
            border-style: solid;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../../script/jquery-3.3.1.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#Toggle').click(function () {
                if ($('#DivSubMenu').is(":visible")) {
                    $('#DivSubMenu').toggle(100);
                    $('#DivContenido').css("width", "100%")
                }
                else if ($('#DivSubMenu').is(":hidden")) {
                    $('#DivSubMenu').toggle(100);
                    $('#DivContenido').css("width", "85%")
                }
            });
            $('#liOrden').click(function () {
                $('#DivGenerar').toggle(400);
                $('#DivActualizar').hide(400);
                $('#DivConsultar').hide(400);
            });
            $('#liConsultar').click(function () {
                $('#DivConsultar').toggle(400);
                $('#DivGenerar').hide(400);
                $('#DivActualizar').hide(400);
            });
            $('#liActualizar').click(function () {
                $('#DivActualizar').toggle(400);
                $('#DivGenerar').hide(400);
                $('#DivConsultar').hide(400);
            });
        });
        $(document).ready(function () {
            $('#DivGenerar').show();
            $('#DivConsultar').hide();
            $('#DivActualizar').hide();
        });
    </script>
    <link href="../../HojasdeEstilos/Orden/EstiloOrden.css" rel="stylesheet" type="text/css" />
    <br />
    <img class="img" id="Toggle" src="../../Recursos/menutoggle.png" />
    <br />
    <div id="DivSubMenu">
        <h2>Opciones</h2>
        <ul id="menu">
            
            <li id="liConsultar">
                <a href="#DivConsultar">Consultar Orden</a>
            </li>
            <li id="liActualizar">
                <a href="#DivActualizar">Actualizar Orden</a>
            </li>
        </ul>
    </div>
    <div id="DivContenido">
        <br/>
        <div id="DivConsultar">
            <h1 id="h1Consultar">Consultar Orden de Viaticos
                <img src="../../Recursos/Mostrar.png" /></h1>
            <asp:TextBox ID="txtBuscar" CssClass="Textbox" runat="server" ValidationGroup="ConsultaOrden" PlaceHolder="Nombre de Usuario" Height="39px" Width="177px"></asp:TextBox><br/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="ConsultaOrden" runat="server" ErrorMessage="Espacio en Blanco" ControlToValidate="txtBuscar" Display="Dynamic" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnBuscar" CssClass="auto-style4" ValidationGroup="ConsultaOrden" runat="server" Text="Buscar" Height="46px" OnClick="btnBuscar_Click" Width="150px" /><br />
            <br />
            <div>
                <asp:GridView CssClass="GridView" ID="GvConsultarSolicitud" AutoGenerateColumns="False" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="FECHAORDEN" HeaderText="Fecha de Orden" />
                        <asp:BoundField DataField="ID_ORDEN" HeaderText="ID Orden" />
                        <asp:BoundField DataField="ID_SOLICITUD" HeaderText="ID Solicitud" />
                        <asp:BoundField DataField="ESTADOORDEN" HeaderText="Estado de Orden" />
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
        </div>
        <br />
        <br />
        <div id="DivActualizar">
            <h1 id="h1Actualizar">Actualizar Orden de Viaticos
                <img src="../../Recursos/Mostrar.png" /></h1>
            <br />
            <asp:GridView ID="GvActualizar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GvActualizar_SelectedIndexChanged" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Seleccione" />
                    <asp:BoundField DataField="ID_ORDEN" HeaderText="ID Orden" />
                    <asp:BoundField DataField="ID_SOLICITUD" HeaderText="ID Solicitud" />
                    <asp:BoundField DataField="ESTADOORDEN" HeaderText="Estado de Orden" />
                    <asp:BoundField DataField="FECHAORDEN" HeaderText="Fecha de Orden" />
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
            <br />
            <asp:TextBox CssClass="Textbox" ID="txtIdOrdenAct" runat="server" PlaceHolder="ID Orden" ReadOnly="True"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="txtIdSolicitudAct" runat="server" PlaceHolder="ID Solicitud" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:DropDownList ID="ddlEstadosActualizar" CssClass="auto-style5" runat="server" Width="280px"></asp:DropDownList>
            <asp:TextBox CssClass="Textbox" ID="txtFechaAct" runat="server" PlaceHolder="Fecha Creacion"></asp:TextBox><br/>
            <br />
            <asp:RegularExpressionValidator ID="ValidadorFecha" runat="server" ErrorMessage="Formato correcto de fecha: dd/mm/yyyy" ControlToValidate="txtFechaAct" ValidationExpression="^\d{2}(/)\d{2}(/)\d{4}$" Display="Dynamic" ForeColor="#CC0000"></asp:RegularExpressionValidator><br />            
            <br />  
            <br />  
            <asp:Button ID="btnGuardar" CssClass="Button" runat="server" Text="Guardar Cambios" OnClick="btnGuardar_Click" />
        </div>
        <br />
        <br />
    </div>
</asp:Content>
