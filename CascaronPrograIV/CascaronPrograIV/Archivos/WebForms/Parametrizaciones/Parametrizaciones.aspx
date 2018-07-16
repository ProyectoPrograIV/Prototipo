<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Parametrizaciones.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Parametrizaciones.Parametrizaciones" %>

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
            $('#liAutobus').click(function () {
                $('#DivAutobus').toggle(400);
                $('#DivViaticos').hide(400);
            });
            $('#liViaticos').click(function () {
                $('#DivViaticos').toggle(400);
                $('#DivAutobus').hide(400);
            });
        });
        $(document).ready(function () {
            $('#DivAutobus').show();
            $('#DivViaticos').hide();
        });
    </script>
    <link href="../../HojasdeEstilos/Parametrizaciones/EstiloParametros.css" rel="stylesheet" type="text/css" />
    <br />
    <img class="img" id="Toggle" src="../../Recursos/menutoggle.png" />
    <br />
    <div id="DivSubMenu">
        <h2>Opciones</h2>
        <ul id="menu">
            <li id="liAutobus">
                <a href="#DivAutobus">Actualizar Tarifas<br />
                    de Autobus</a>
            </li>
            <li id="liViaticos">
                <a href="#DivViaticos">Actualizar Tarifas<br />
                    de Viaticos</a>
            </li>
        </ul>
    </div>
    <div id="DivContenido">
        <div id="DivAutobus">
            <h1 id="h1Autobus">Actulizar Tarifas de Autobus
            <img src="../../Recursos/Mostrar.png" />
        </h1>
            <asp:TextBox CssClass="TbxFiltrar" ID="TextBox7" runat="server" Text="Buscar"></asp:TextBox>
            <asp:GridView ID="GvTarifaAutobus" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:TextBox CssClass="Textbox" ID="TextBox1" runat="server" Text="Codigo de Ruta"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox2" runat="server" Text="Provincia"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox3" runat="server" Text="Tarifa"></asp:TextBox><br />
            <asp:TextBox CssClass="Textbox" ID="TextBox4" runat="server" Text="Descripcion"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox5" runat="server" Text="Fecha Vigente"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox6" runat="server" Text="Estado"></asp:TextBox><br />
            <br />
            <br />
            <asp:Button ID="Btn_Actualizar" CssClass="Button" runat="server" Text="Actualizar" />
        </div>
        <br />
        <br />
        <div id="DivViaticos">
            <h1 id="h1Viaticos">Actualizar Tarifas de Viaticos
            <img src="../../Recursos/Mostrar.png" /></h1>
            <asp:TextBox ID="TbxFiltrar" CssClass="TbxFiltrar" runat="server" Text="Buscar"></asp:TextBox>
            <asp:GridView CssClass="GridView" ID="GvTarifaViaticos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <asp:TextBox CssClass="Textbox" ID="TextBox8" runat="server" Text="Tipo de Tarifa"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox9" runat="server" Text="Monto"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox10" runat="server" Text="Fecha"></asp:TextBox><br />
            <asp:TextBox CssClass="Textbox" ID="TextBox11" runat="server" Text="Localidad"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox12" runat="server" Text="Provincia"></asp:TextBox>
            <asp:TextBox CssClass="Textbox" ID="TextBox13" runat="server" Text="Canton"></asp:TextBox><br />
            <asp:TextBox CssClass="Textbox" ID="TextBox14" runat="server" Text="Estado"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" CssClass="Button" runat="server" Text="Actualizar" />
        </div>
        <br />
        <br />
    </div>
</asp:Content>
