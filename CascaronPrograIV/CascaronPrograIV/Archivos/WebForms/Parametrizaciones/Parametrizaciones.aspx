<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Parametrizaciones.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Parametrizaciones.Parametrizaciones" %>

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
            <h1 id="h1Autobus">Actualizar Tarifas de Autobus
            <img src="../../Recursos/Mostrar.png" />
        </h1>
            <asp:TextBox CssClass="TbxFiltrar" ID="TextBox7" runat="server" Text="Buscar"></asp:TextBox>
            <asp:GridView ID="GvTarifaAutobus"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" 
                  >
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
            
            
            
            
            
            
            
           
            <table style="width: 100%;">
                <tr>
                    <td><h5>ID TARIFA</h5><asp:TextBox ID="TbxFiltrar" CssClass="auto-style2" runat="server" placeholder="Id Tarifa Viatico" Width="195px" ReadOnly="True"></asp:TextBox></td>
                    <td><h5>TIPO TARIFA</h5><asp:TextBox CssClass="Textbox" ID="TbxTipoTarifa" runat="server" placeholder="Tipo de Tarifa" ReadOnly="True"></asp:TextBox></td>
                    <td><h5>MONTO DE TARIFA</h5><asp:TextBox CssClass="Textbox" ID="TbxMonto" runat="server" placeholder="Monto"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h5>FECHA</h5><asp:TextBox CssClass="Textbox" ID="TbxFecha" runat="server" placeholder="Fecha"></asp:TextBox><br /></td>
                    <td><h5>LOCALIDAD</h5><asp:TextBox CssClass="Textbox" ID="TbxLocalidad" runat="server" placeholder="Localidad" ReadOnly="True"></asp:TextBox></td>
                    <td><h5>PROVINCIA</h5><asp:TextBox CssClass="Textbox" ID="Tbxprovincia" runat="server" placeholder="Provincia" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h5>CANTON</h5><asp:TextBox CssClass="Textbox" ID="TbxCanton" runat="server" placeholder="Canton" ReadOnly="True"></asp:TextBox><br /></td>
                    <td><h5>ESTADO TARIFA</h5> <asp:DropDownList ID="cbEstado" runat="server">
                        <asp:ListItem Value="10">Activo</asp:ListItem>
                        <asp:ListItem Value="9">Inactivo</asp:ListItem>
                        </asp:DropDownList> </td>
                  <td> </td>
                </tr>
                <tr>
                     <td colspan="3"> <asp:Button ID="btnActualizar" CssClass="Button" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" /> </td>

                </tr> 
                 
            </table>

           
            <asp:GridView CssClass="GridView" ID="GvTarifaViaticos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False"
                 OnSelectedIndexChanged="GvTarifaViaticos_SelectedIndexChanged" AllowPaging="true" PageSize="10" OnPageIndexChanging="GvTarifaViaticos_PageIndexChanging" OnSelectedIndexChanging="GvTarifaViaticos_SelectedIndexChanging">
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
              <Columns>
                  <asp:CommandField ShowSelectButton="true" SelectText="Selecione" ItemStyle-Width="4%" />
                  <asp:BoundField HeaderText="ID TARIFA" DataField="ID_MODTARIFA"  ItemStyle-Width="12%"/>
                  <asp:BoundField HeaderText="PROVINCIA" DataField="CODIGOPROVINCIA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="CANTON" DataField="CODIGOCANTON"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="TIPO" DataField="TIPOTARIFA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="FECHA" DataField="FECHATARIFA"  ItemStyle-Width="12%"/>
                  <asp:BoundField HeaderText="MONTO" DataField="MONTOTARIFA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="ESTADO" DataField="ESTADOTARIFA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="LOCALIDAD" DataField="LOCALIDAD"  ItemStyle-Width="12%" />                         
              </Columns>


            </asp:GridView>
         
            <br />
            <br />


            
        </div>
        <br />
        <br />
    </div>
</asp:Content>
