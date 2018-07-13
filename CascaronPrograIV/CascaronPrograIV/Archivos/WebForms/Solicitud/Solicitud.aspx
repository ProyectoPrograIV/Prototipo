<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Solicitud.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.Solicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            $('#h1Crear').click(function () {
                $('#DivCrear').toggle(999);
                $('#DivConsultar').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivVerificar').hide(999);
            });
            $('#h1Consultar').click(function () {
                $('#DivConsultar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivVerificar').hide(999);
            });
            $('#h1Actualizar').click(function () {
                $('#DivActualizar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivConsultar').hide(999);
                $('#DivVerificar').hide(999);
            });
            $('#h1Verificar').click(function () {
                $('#DivVerificar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivConsultar').hide(999);
            });
            $('#liCrear').click(function () {
                $('#DivCrear').toggle(999);
                $('#DivVerificar').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivConsultar').hide(999);
            });
            $('#liConsultar').click(function () {
                $('#DivConsultar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivVerificar').hide(999);
            });
            $('#liActualizar').click(function () {
                $('#DivActualizar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivVerificar').hide(999);
                $('#DivConsultar').hide(999);
            });
            $('#liVerificar').click(function () {
                $('#DivVerificar').toggle(999);
                $('#DivCrear').hide(999);
                $('#DivActualizar').hide(999);
                $('#DivConsultar').hide(999);
            });
        });
        $(document).ready(function () {
            $('#DivCrear').hide();
            $('#DivConsultar').hide();
            $('#DivActualizar').hide();
            $('#DivVerificar').hide();
        });
    </script>
    <link href="../../HojasdeEstilos/Solicitud/EstiloSolicitud.css" rel="stylesheet" type="text/css" />
    <br />
    <img class="img" id="Toggle" src="../../Recursos/menutoggle.png" />
    <br />
    <div id="DivSubMenu">
        <h2>Opciones</h2>
        <ul id="menu">
            <li id="liCrear">
                <a href="#DivCrear">Crear Solicitud</a>
            </li>
            <li id="liConsultar">
                <a href="#DivConsultar">Consultar Solicitud</a>
            </li>
            <li id="liActualizar">
                <a href="#DivActualizar">Actualizar Solicitud</a>
            </li>
            <li id="liVerificar">
                <a href="#DivVerificar">Verificar Solicitud</a>
            </li>
        </ul>
    </div>
    <div id="DivContenido">
        <h1 id="h1Crear" title="Click para mostrar contenido">Crear Solicitud de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
        <div id="DivCrear">
            <br />
            <asp:TextBox CssClass="Textbox" ID="TextBox1" runat="server" Text="Fecha de Creacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox2" runat="server" Text="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox3" runat="server" Text="Estado de Solicitud"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox4" runat="server" Text="Usuario"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox5" runat="server" Text="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox6" runat="server" Text="Destino"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox7" runat="server" Text="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox8" runat="server" Text="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox9" runat="server" Text="Hora de Regreso"></asp:TextBox><br />
            <br />
            <asp:Button ID="Btn_Guardar" CssClass="Button" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click" />
        </div>
        <br />
        <br />
        <h1 id="h1Consultar" title="Click para mostrar contenido">Consultar Solicitudes de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
        <div id="DivConsultar">
            <asp:TextBox ID="TbxFiltrar" CssClass="TbxFiltrar" runat="server" Text="Buscar"></asp:TextBox>
            <div>
                <asp:GridView CssClass="GridView" ID="GvConsultarSolicitud" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <h1 id="h1Actualizar" title="Click para mostrar contenido">Actualizar Solicitud de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
        <div id="DivActualizar">
            <br />
            <asp:TextBox CssClass="Textbox" ID="TextBox20" runat="server" Text="Buscar"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GvActualizar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:TextBox CssClass="Textbox" ID="TextBox10" runat="server" Text="Fecha de Creacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox11" runat="server" Text="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox12" runat="server" Text="Estado de Solicitud"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox13" runat="server" Text="Usuario"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox14" runat="server" Text="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox15" runat="server" Text="Destino"></asp:TextBox><br />

            <asp:TextBox CssClass="Textbox" ID="TextBox16" runat="server" Text="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox17" runat="server" Text="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox18" runat="server" Text="Hora de Regreso"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click" />
        </div>
        <br />
        <br />
        <h1 id="h1Verificar" title="Click para mostrar contenido">Verificar Solicitudes de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
        <div id="DivVerificar">
            <asp:TextBox CssClass="Textbox" ID="TextBox19" runat="server" Text="Buscar"></asp:TextBox>
            <asp:GridView ID="GvVerificar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:Button CssClass="Button" ID="Button2" runat="server" Text="Rechazar" />
            <asp:Button CssClass="Button" ID="Button3" runat="server" Text="Aceptar" />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
