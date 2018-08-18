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
        .auto-style3 {
            margin: 20px;
            text-align: center;
            color: #ADADAD;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: 900;
            font-size: 18px;
            border-style: solid;
        }
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

            <table style="width: 100%;">
                <tr>
                    <td><h3>Id Ruta</h3><asp:TextBox CssClass="auto-style3" ID="TbxIdRutaBus" runat="server" placeholder="Ingrese Id Ruta" Width="202px" Height="35px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TbxIdRutaBus" ErrorMessage="Debe de Ingresar el ID de Ruta para Actualizar" ForeColor="Red" ValidationGroup="TARIFABUSES">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TbxIdRutaBus" ErrorMessage="Rango de IDs de Ruta Permitidos es de 1-3560" ForeColor="Red" MaximumValue="3560" MinimumValue="1" ValidationGroup="TARIFABUSES">*</asp:RangeValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TbxIdRutaBus" ErrorMessage="Rango de IDs de Ruta Permitidos es de 1-3560" ForeColor="Red" MaximumValue="3560" MinimumValue="1" ValidationGroup="TARIFABUSES2">*</asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TbxIdRutaBus" ErrorMessage="Debe de Ingresar el ID de Ruta para poder realizar la busqueda y luego proceder a Actualizar" ForeColor="Red" ValidationGroup="TARIFABUSES2">*</asp:RequiredFieldValidator>
                    </td>
                    <td><h3>Estado Ruta</h3>  <asp:DropDownList ID="dlEstadoBuses"  runat="server" Height="52px" Width="191px">
                        <asp:ListItem Value="10">Activo</asp:ListItem>
                        <asp:ListItem Value="9">Inactivo</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td><h3>Tarifa</h3><asp:TextBox CssClass="Textbox" ID="TbxTarifaBus" runat="server" placeholder="Tarifa"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TbxTarifaBus" ErrorMessage="Debe Ingresar Numeros en este Campo, se aceptan decimales" ForeColor="Red" ValidationExpression="^(\d|-)?(\d|,)*\.?\d*$" ValidationGroup="TARIFABUSES">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe de Ingresar la Tarifa" ForeColor="Red" ControlToValidate="TbxTarifaBus" ValidationGroup="TARIFABUSES">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    
                    <td><h3>Descripcion</h3><asp:TextBox CssClass="Textbox" ID="TbxDescripcionBus" runat="server" placeholder="Descripcion"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe de Ingresar el Nombre de la Ruta" ControlToValidate="TbxDescripcionBus" ForeColor="Red" ValidationGroup="TARIFABUSES">*</asp:RequiredFieldValidator>
                    </td>
                    <td><h3>Fecha Vigencia</h3><asp:TextBox CssClass="Textbox" ID="TbxFechaVigenteBus" runat="server" placeholder="Fecha Vigente"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe de Ingresar Fecha de Vigencia de la Ruta de Autobus" ControlToValidate="TbxFechaVigenteBus" ForeColor="Red" ValidationGroup="TARIFABUSES">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TbxFechaVigenteBus" ErrorMessage="Formato de Fecha Invalido debe de ingresar por Ejm: dd/mm/yyyy" ForeColor="Red" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ValidationGroup="TARIFABUSES">*</asp:RegularExpressionValidator>
                    </td>
                    <td><asp:Button ID="Btn_ActualizarBus" CssClass="auto-style4" runat="server" Text="ActualizarBus"  ValidationGroup="TARIFABUSES" Enabled="False" OnClick="Btn_ActualizarBus_Click" Height="48px"/></td>
                </tr>
                <tr>                     
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="TARIFABUSES2" />
                        <asp:ValidationSummary ID="ValidationTarifaBuses" runat="server" ForeColor="Red" ValidationGroup="TARIFABUSES" Width="605px" /></td>  
                    <td><asp:Button ID="Btn_Buscar" CssClass="auto-style4" runat="server" Text="BUSCAR CON ID TARIFA" Width="258px" OnClick="Btn_Buscar_Click" ValidationGroup="TARIFABUSES2" Height="57px"/> </td>                             
                </tr>
            </table>
           
            <asp:GridView ID="GvTarifaAutobus"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
                AllowPaging="true" PageSize="100" OnPageIndexChanging="GvTarifaAutobus_PageIndexChanging"   >
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
                  <asp:BoundField HeaderText="CODIGO RUTA" DataField="CODIGORUTA"  ItemStyle-Width="12%"/>
                  <asp:BoundField HeaderText="ESTADO RUTA" DataField="ESTADORUTA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="TARIFA REGISTRADA" DataField="TARIFAREGISTRADA"  ItemStyle-Width="12%" />
                  <asp:BoundField HeaderText="DESCRIPCION RUTA" DataField="DESCRIPCIONRUTA"  ItemStyle-Width="50%" />
                  <asp:BoundField HeaderText="FECHA VIGENCIA" DataField="FECHAVIGENCIA"  ItemStyle-Width="12%"/>                        
              </Columns>

            </asp:GridView>
            
           
        
            
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
                    <td><h5>MONTO DE TARIFA</h5><asp:TextBox CssClass="Textbox" ID="TbxMonto" runat="server" placeholder="Monto"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TbxMonto" ErrorMessage="Ingrese el Monto de Tarifa" ForeColor="Red" ValidationGroup="TARIFA_HOSPEDA">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TbxMonto" Display="Dynamic" ErrorMessage="Solo puede Ingresar Numeros" ForeColor="Red" ValidationExpression="^(\d|-)?(\d|,)*\.?\d*$" ValidationGroup="TARIFA_HOSPEDA">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td><h5>FECHA</h5><asp:TextBox CssClass="Textbox" ID="TbxFecha" runat="server" placeholder="Fecha"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TbxFecha" ErrorMessage="Ingrese la Fecha de Vecimiento" ForeColor="Red" ValidationGroup="TARIFA_HOSPEDA">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TbxFecha" ErrorMessage="Formato de Fecha Invalido, Ejm: 30/11/2017" ForeColor="Red" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ValidationGroup="TARIFA_HOSPEDA">*</asp:RegularExpressionValidator>
                        <br /></td>
                    <td><h5>LOCALIDAD</h5><asp:TextBox CssClass="Textbox" ID="TbxLocalidad" runat="server" placeholder="Localidad" ReadOnly="True"></asp:TextBox></td>
                    <td><h5>PROVINCIA</h5><asp:TextBox CssClass="Textbox" ID="Tbxprovincia" runat="server" placeholder="Provincia" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h5>CANTON</h5><asp:TextBox CssClass="Textbox" ID="TbxCanton" runat="server" placeholder="Canton" ReadOnly="True"></asp:TextBox><br /></td>
                    <td><h5>ESTADO TARIFA</h5> <asp:DropDownList ID="cbEstado" runat="server">
                        <asp:ListItem Value="10">Activo</asp:ListItem>
                        <asp:ListItem Value="9">Inactivo</asp:ListItem>
                        </asp:DropDownList> </td>
                  <td> 
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="TARIFA_HOSPEDA" />
                    </td>
                </tr>
                <tr>
                     <td colspan="3"> <asp:Button ID="btnActualizar" CssClass="Button" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" ValidationGroup="TARIFA_HOSPEDA" /> </td>

                </tr> 
                 
            </table>

           
            <asp:GridView CssClass="GridView" ID="GvTarifaViaticos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False"
                 OnSelectedIndexChanged="GvTarifaViaticos_SelectedIndexChanged" AllowPaging="true" PageSize="10" OnPageIndexChanging="GvTarifaViaticos_PageIndexChanging"
                 OnSelectedIndexChanging="GvTarifaViaticos_SelectedIndexChanging">
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
