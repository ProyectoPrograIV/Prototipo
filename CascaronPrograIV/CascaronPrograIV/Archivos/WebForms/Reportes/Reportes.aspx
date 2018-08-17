<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Reportes.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta charset="utf-8" />
    <script src="../../script/jquery-3.3.1.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            
        });
        $(document).ready(function () {
            $('#Div1').show();
            $('#Div2').hide();
            $('#Div3').hide();
            $('#Div4').hide();
            $('#Div5').hide();
            $('#Div6').hide();
        });
    </script>
    <link href="../../HojasdeEstilos/Reportes/EstiloReportes.css" rel="stylesheet" type="text/css" />
    <br />

    <div id="DivContenido">
        <div id="Div1" style="margin-left:5%">


            <h1 id="h1TituloDiv" runat="server">Listado de Viaticos</h1>


            <div class="Fecha">
                <h3>Filtrar por Tipo</h3>
                <asp:DropDownList CssClass="TbxFecha"  ID="ddlTipoReporte" runat="server" AutoPostBack="false" OnTextChanged="ddlTipoReporte_TextChanged"></asp:DropDownList>
            </div>

            <div class="Fecha">
                <h3>Fecha Inicial</h3>
                <asp:TextBox CssClass="TbxFecha" ID="txtFechaInicial" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RFV1" runat="server" ErrorMessage="Debe llenar este espacio"  Display="Dynamic" ControlToValidate="txtFechaInicial" ForeColor="Red"></asp:RequiredFieldValidator>

            <div class="Fecha">
                <h3>Fecha Final</h3>
                <asp:TextBox CssClass="TbxFecha" ID="txtFechaFinal" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RFV2" runat="server" ErrorMessage="Debe llenar este espacio"  Display="Dynamic" ControlToValidate="txtFechaFinal" ForeColor="Red"></asp:RequiredFieldValidator>

            <div class="Fecha">
                <h3>Estado</h3>
                <asp:DropDownList CssClass="TbxFecha"  ID="ddlEstados" runat="server" AutoPostBack="false" OnTextChanged="ddlEstados_TextChanged"></asp:DropDownList>
            </div>

            <br />
            <asp:Button CssClass="Button" ID="btnBuscarViaticos" UseSubmitBehavior="false" runat="server" Text="Buscar Viaticos" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:GridView CssClass="GridView" ID="gvViaticos" runat="server" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None">
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
</asp:Content>
