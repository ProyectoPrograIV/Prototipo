﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Solicitud.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.Solicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../../script/jquery-3.3.1.min.js"></script>
    <script type="text/javascript">
        function Inicio() {
            $('#Solicitud').show();
            $('#InicioSolicitud').hide();
            $('#DetalleViatico').hide();
        };
        function Negado() {
            $('#InicioSolicitud').show();
            $('#Solicitud').hide();
            $('#DetalleViatico').hide();
        };
        function Solicitud() {
            $('#InicioSolicitud').hide();
            $('#Solicitud').hide();
            $('#DetalleViatico').show();
        };
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
            $('#liCrear').click(function () {
                $('#DivCrear').toggle(400);
                $('#DivVerificar').hide(400);
                $('#DivActualizar').hide(400);
                $('#DivConsultar').hide(400);
            });
            $('#liConsultar').click(function () {
                $('#DivConsultar').toggle(400);
                $('#DivCrear').hide(400);
                $('#DivActualizar').hide(400);
                $('#DivVerificar').hide(400);
            });
            $('#liActualizar').click(function () {
                $('#DivActualizar').toggle(400);
                $('#DivCrear').hide(400);
                $('#DivVerificar').hide(400);
                $('#DivConsultar').hide(400);
            });
            $('#liVerificar').click(function () {
                $('#DivVerificar').toggle(400);
                $('#DivCrear').hide(400);
                $('#DivActualizar').hide(400);
                $('#DivConsultar').hide(400);
            });
        });
        $(document).ready(function () {
            $('#DivCrear').show();
            $('#DivConsultar').hide();
            $('#DivActualizar').hide();
            $('#DivVerificar').hide();
            $('#Solicitud').hide();
            $('#DetalleViatico').hide();
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
        <asp:ScriptManager runat="server" ID="ScripManagerCsharp" EnableCdn="true" EnablePageMethods="True">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdateList" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div id="DivCrear">
                    <h1 id="h1Crear" title="Click para mostrar contenido">Crear Solicitud de Viaticos</h1>
                    <div id="InicioSolicitud" style="text-align: center">
                        <asp:DropDownList CssClass="DDL" ID="Ddl_PersonasSolicitud" runat="server"></asp:DropDownList>
                        <asp:Button CssClass="Button" ID="BtnAgregarPersona" runat="server" Text="Agregar Persona" OnClick="BtnAgregarPersona_Click" />
                        <br />
                        <asp:GridView CssClass="GvPersonas" ID="GvPersonas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateDeleteButton="True" OnRowCommand="GvPersonas_RowCommand" ShowHeaderWhenEmpty="True" OnRowDeleting="GvPersonas_RowDeleting">
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
                        <asp:Button CssClass="Button" ID="BtnIniciar" runat="server" Text="Siguiente" OnClick="BtnIniciar_Click" />
                        <br />
                    </div>
                    <div id="Solicitud">
                        <asp:TextBox ID="TbxUsuario" runat="server" CssClass="Textbox" placeholder="Usuario" ReadOnly="True"></asp:TextBox>
                        <br />
                        <asp:TextBox CssClass="Textbox" ID="TbxFechaRegreso" runat="server" placeholder="Fecha de Regreso"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="TbxFechaSalida" runat="server" placeholder="Fecha de Salida"></asp:TextBox>
                        <br />
                        <asp:TextBox CssClass="Textbox" ID="TbxJustificacion" runat="server" placeholder="Justificacion"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="TbxDestino" runat="server" placeholder="Destino"></asp:TextBox>
                        <br />
                        <asp:TextBox CssClass="Textbox" ID="TbxHoraSalida" runat="server" placeholder="Hora de Salida"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="TbxHoraRegreso" runat="server" placeholder="Hora de Regreso"></asp:TextBox><br />
                        <br />
                        <asp:Button ID="Btn_SolcitudReg" CssClass="Button" runat="server" Text="Regresar" OnClick="Btn_SolcitudReg_Click" />
                        <asp:Button ID="Btn_SolicitudSig" CssClass="Button" runat="server" Text="Siguiente" OnClick="Btn_SolicitudSig_Click" />
                        <div id="DivValidaciones">
                            <asp:Label ID="Validaciones" runat="server"></asp:Label><br />
                            <asp:RegularExpressionValidator ID="ValidadorFechaSalida" runat="server" ErrorMessage="Fecha de salida incorrecta, forma correcta ##/##/####" ControlToValidate="TbxFechaSalida" ValidationExpression="^\d{2}(/)\d{2}(/)\d{4}$"></asp:RegularExpressionValidator><br />
                            <asp:RegularExpressionValidator ID="ValidadorFechaRegreso" runat="server" ErrorMessage="Fecha de regreso incorrecta, forma correcta ##/##/####" ControlToValidate="TbxFechaRegreso" ValidationExpression="^\d{2}(/)\d{2}(/)\d{4}$"></asp:RegularExpressionValidator><br />
                        </div>
                    </div>

                    <div id="DetalleViatico">
                        <br />
                        <asp:TextBox CssClass="Textbox" ID="Tbx_CantDes" runat="server" placeholder="Cantidad de Desayunos"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_CantAlm" runat="server" placeholder="Cantidad de Almuerzos"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_CantCenas" runat="server" placeholder="Cantidad de Cenas"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_CantPasaj" runat="server" placeholder="Cantidad de Pasajes"></asp:TextBox>
                        <br />
                        <asp:TextBox CssClass="Textbox" ID="Tbx_MontDes" runat="server" placeholder="Monto Total de Desayunos"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_MontAlm" runat="server" placeholder="Monto Total de Almuerzos"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_MontCenas" runat="server" placeholder="Monto Total de Cenas"></asp:TextBox>
                        <asp:TextBox CssClass="Textbox" ID="Tbx_MontPasaj" runat="server" placeholder="Monto Total de Pasajes"></asp:TextBox>
                        <br />
                        <asp:DropDownList CssClass="DDL" ID="Ddl_Ruta" runat="server"></asp:DropDownList>
                        <br />
                        <br />
                        <asp:DropDownList CssClass="DDL" ID="Ddl_Hospedaje" runat="server"></asp:DropDownList>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="BtnDetalleReg" CssClass="Button" runat="server" Text="Regresar" OnClick="BtnDetalleReg_Click" />
                        <asp:Button ID="BtnGuardar" CssClass="Button" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                        <div id="DivValidaciones2">
                            <asp:Label ID="Label1" runat="server"></asp:Label><br />
                        </div>
                    </div>
                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <div id="DivConsultar">
            <h1 id="h1Consultar" title="Click para mostrar contenido">Consultar Solicitudes de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
            <asp:TextBox ID="TbxFiltrar" CssClass="TbxFiltrar" runat="server" Text="Buscar" OnTextChanged="TbxFiltrar_TextChanged"></asp:TextBox>
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
        <div id="DivActualizar">
            <h1 id="h1Actualizar" title="Click para mostrar contenido">Actualizar Solicitud de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
            <br />
            <asp:TextBox CssClass="Textbox" ID="TextBox20" runat="server" Text="Buscar"></asp:TextBox>
            <br />
            <br />
            <asp:GridView CssClass="GridView" ID="GvActualizar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:TextBox CssClass="Textbox" ID="TbxActuFechaRegreso" runat="server" placeholder="Fecha de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuFechaSalida" runat="server" placeholder="Fecha de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuJustificacion" runat="server" placeholder="Justificacion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuDestino" runat="server" placeholder="Destino"></asp:TextBox>
            <br />
            <asp:TextBox CssClass="Textbox" ID="TbxActuHoraSalida" runat="server" placeholder="Hora de Salida"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuHoraRegreso" runat="server" placeholder="Hora de Regreso"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuCantDesayunos" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuCantAlmuerzos" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox CssClass="Textbox" ID="TbxActuCantCenas" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuCantPasajes" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuMontDesayunos" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuMontAlmuerzos" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox CssClass="Textbox" ID="TbxActuMontCenas" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TbxActuMontPasajes" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList CssClass="DDL" ID="Ddl_ActuRutas" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList CssClass="DDL" ID="Ddl_ActuLocalidad" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Modificar" />
        </div>
        <br />
        <br />
        <div id="DivVerificar">
            <h1 id="h1Verificar" title="Click para mostrar contenido">Verificar Solicitudes de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
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
