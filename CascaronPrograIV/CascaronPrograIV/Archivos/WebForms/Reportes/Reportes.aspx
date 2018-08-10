<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Reportes.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta charset="utf-8" />
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
            $('#LiViaticos').click(function () {
                 $('#Div1').hide();
                $('#Div1').toggle(400);
                $('#h1TituloDiv').text('Listado Viáticos')
                $("#<%=btnBuscarViaticos.ClientID%>").val('Buscar Viaticos');

               $("#<%=btnBuscarViaticos.ClientID%>").attr('value','1');
                $('#Div2').hide();
                $('#Div3').hide();
                $('#Div4').hide();
                $('#Div5').hide();
                $('#Div6').hide();
            });
            $('#LiSolicitudes').click(function () {
                $('#h1TituloDiv').text('Listado Solicitudes')
                $('#Div1').hide();
                 $('#Div1').toggle(400);
                 $("#<%=btnBuscarViaticos.ClientID%>").val('Buscar Solicitudes');

                $("#<%=btnBuscarViaticos.ClientID%>").attr('value','2');
     
                $('#Div3').hide();
                $('#Div4').hide();
                $('#Div5').hide();
                $('#Div6').hide();
            });
            $('#LiLiquidaciones').click(function () {
               // $('#Div1').hide();
               // $('#Div2').hide();
                //$('#Div3').toggle(400);
                
                $('#h1TituloDiv').text('Listado Liquidaciones')
                 $('#Div1').hide();
                $('#Div1').toggle(400);

                 $("#<%=btnBuscarViaticos.ClientID%>").val('Buscar Liquidaciones');

               $("#<%=btnBuscarViaticos.ClientID%>").attr('value','3');
     
                $('#Div4').hide();
                $('#Div5').hide();
                $('#Div6').hide();
            });
            $('#LiSolicitudPendiente').click(function () {
                $('#Div1').hide();
                $('#Div2').hide();
                $('#Div3').hide();
                $('#Div4').toggle(400);
                $('#Div5').hide();
                $('#Div6').hide();
            });
            $('#LiLiquidacionTramitar').click(function () {
                $('#Div1').hide();
                $('#Div2').hide();
                $('#Div3').hide();
                $('#Div4').hide();
                $('#Div5').toggle(400);
                $('#Div6').hide();
            });
            $('#LiLiquidacionesAprobar').click(function () {
                $('#Div1').hide();
                $('#Div2').hide();
                $('#Div3').hide();
                $('#Div4').hide();
                $('#Div5').hide();
                $('#Div6').toggle(400);
            });
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
    <img id="Toggle" class="img" src="../../Recursos/menutoggle.png" />
    <br />
    <div id="DivSubMenu">
        <h2>Opciones</h2>
        <ul id="SubMenu">
            <li class="Item" id="LiViaticos">
                <a class="Link" href="#">Listado de Viaticos</a>
            </li>
            <li class="Item" id="LiSolicitudes">
                <a class="Link" href="#">Listado de Solicitudes</a>
            </li>
            <li class="Item" id="LiLiquidaciones">
                <a class="Link" href="#">Listado de Liquidaciones</a>
            </li>
            <li class="Item" id="LiSolicitudPendiente">
                <a class="Link" href="#">Solicitudes Pendientes de Aprobar</a>
            </li>
            <li class="Item" id="LiLiquidacionTramitar">
                <a class="Link" href="#">Liquidaciones Pendientes de Tramitar</a>
            </li>
            <li class="Item" id="LiLiquidacionesAprobar">
                <a class="Link" href="#">Liquidaciones Pendientes de Aprobar</a>
            </li>
        </ul>
    </div>
    <div id="DivContenido">
        <div id="Div1">
            <h1 id="h1TituloDiv">Listado de Viaticos</h1>
            <div class="Fecha">
                <h3>Fecha Inicial</h3>
                <asp:TextBox CssClass="TbxFecha" ID="txtFechaInicial" runat="server" TextMode="Date"></asp:TextBox>
                   
            </div>
               <asp:RequiredFieldValidator ID="RFV1" runat="server" ErrorMessage="Debe llenar este espacio" ControlToValidate="txtFechaInicial" ForeColor="Red"></asp:RequiredFieldValidator>
      
            <div class="Fecha">
                <h3>Fecha Final</h3>
                <asp:TextBox CssClass="TbxFecha" ID="txtFechaFinal" runat="server" TextMode="Date" ></asp:TextBox>

                
            </div>
            <asp:RequiredFieldValidator ID="RFV2" runat="server" ErrorMessage="Debe llenar este espacio" ControlToValidate="txtFechaFinal" ForeColor="Red"></asp:RequiredFieldValidator>
      
            <br />
            <asp:Button CssClass="Button" ID="btnBuscarViaticos" runat="server" Text="Buscar Viaticos" OnClick="btnBuscar_Click"/>
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
        <div id="Div2">
            <h1>Listado de Solicitudes</h1>
            <div class="Fecha">
                <h3>Fecha Inicial</h3>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox4" runat="server" placeholder="Dia"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox5" runat="server" placeholder="Mes"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox6" runat="server" placeholder="Año"></asp:TextBox>
            </div>
            <div class="Fecha">
                <h3>Fecha Final</h3>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox7" runat="server" placeholder="Dia"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox8" runat="server" placeholder="Mes"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox9" runat="server" placeholder="Año"></asp:TextBox>
            </div>
            <br />
            <asp:Button CssClass="Button" ID="Button2" runat="server" Text="Buscar Solicitudes" />
            <br />
            <br />
            <asp:GridView CssClass="GridView" ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <div id="Div3">
            <h1>Listado de Liquidaciones</h1>
            <div class="Fecha">
                <h3>Fecha Inicial</h3>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox10" runat="server" placeholder="Dia"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox11" runat="server" placeholder="Mes"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox12" runat="server" placeholder="Año"></asp:TextBox>
            </div>
            <div class="Fecha">
                <h3>Fecha Final</h3>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox13" runat="server" placeholder="Dia"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox14" runat="server" placeholder="Mes"></asp:TextBox>
                <asp:TextBox CssClass="TbxFecha" ID="TextBox15" runat="server" placeholder="Año"></asp:TextBox>
            </div>
            <br />
            <asp:Button CssClass="Button" ID="Button3" runat="server" Text="Buscar Viaticos" />
            <br />
            <br />
            <asp:GridView CssClass="GridView" ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <div id="Div4">
            <h1>Solicitudes Pendientes de Aprobar</h1>
        </div>
        <div id="Div5">
            <h1>Liquidaciones Pendientes de Tramitar</h1>
        </div>
        <div id="Div6">
            <h1>Liquidaciones Pendientes de Aprobar</h1>
        </div>
    </div>
</asp:Content>
