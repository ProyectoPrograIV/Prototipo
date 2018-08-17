<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Orden.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Orden.Orden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin: 20px;
            text-align: center;
            color: #ADADAD;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: 900;
            font-size: 22px;
            border-style: solid;
        }

        .auto-style3 {
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
            <li id="liOrden">
                <a href="#DivGenerar">Generar Orden</a>
            </li>
            <li id="liConsultar">
                <a href="#DivConsultar">Consultar Orden</a>
            </li>
            <li id="liActualizar">
                <a href="#DivActualizar">Actualizar Orden</a>
            </li>
        </ul>
    </div>
    <div id="DivContenido">
        <div id="DivGenerar">
            <h1 id="h1Generar">Generar Orden de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>

            <asp:TextBox CssClass="Textbox" ID="txtID" runat="server" Placeholder="ID Solicitud"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="txtUsuario" runat="server" Placeholder="Usuario"></asp:TextBox>
            <asp:DropDownList ID="ddlEstado" CssClass="TbxFiltrar" runat="server"></asp:DropDownList>
            <br />            
            <asp:TextBox CssClass="Textbox" ID="TextBox5" runat="server" Placeholder="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox6" runat="server" Placeholder="Destino"></asp:TextBox>
            <br />
            <asp:TextBox CssClass="Textbox" ID="TextBox7" runat="server" Placeholder="Fecha de Salida"></asp:TextBox>
            <asp:Button ID="Btn_Generar" CssClass="Button" runat="server" Text="Generar" OnClick="Btn_Generar_Click" />
        </div>
        <br />
        <br />
        <div id="DivConsultar">
            <h1 id="h1Consultar">Consultar Orden de Viaticos
                <img src="../../Recursos/Mostrar.png" /></h1>
            <asp:TextBox ID="txtBuscar" CssClass="auto-style2" runat="server" PlaceHolder="Buscar" Height="39px" Width="208px"></asp:TextBox>
            <asp:Button ID="btnBuscar" CssClass="auto-style3" runat="server" Text="Buscar" Height="40px" OnClick="btnBuscar_Click" Width="150px" />
            <div>
                <asp:GridView CssClass="GridView" ID="GvConsultarSolicitud" AutoGenerateColumns="true" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
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
            <asp:TextBox CssClass="Textbox" ID="TextBox20" runat="server" PlaceHolder="nombre usuario"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GvActualizar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GvActualizar_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
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
            <asp:TextBox CssClass="Textbox" ID="TextBox10" runat="server" PlaceHolder="Fecha de Creacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox11" runat="server" PlaceHolder="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox12" runat="server" PlaceHolder="Estado de Solicitud"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox13" runat="server" PlaceHolder="Usuario"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox14" runat="server" PlaceHolder="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox15" runat="server" PlaceHolder="Destino"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox16" runat="server" PlaceHolder="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox17" runat="server" PlaceHolder="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox18" runat="server" PlaceHolder="Hora de Regreso"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnGuardar" CssClass="Button" runat="server" Text="Guardar" />
        </div>
        <br />
        <br />
    </div>
</asp:Content>
