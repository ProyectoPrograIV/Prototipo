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
                    <td><h3>Id Ruta</h3><asp:TextBox CssClass="auto-style3" ID="TbxIdRuta" runat="server" placeholder="Ingrese Id Ruta" Width="202px" Height="35px"></asp:TextBox></td>
                    <td><h3>Estado Ruta</h3>  <asp:DropDownList ID="DropDownList1" runat="server" Height="52px" Width="191px">
                        <asp:ListItem Value="10">Activo</asp:ListItem>
                        <asp:ListItem Value="9">Inactivo</asp:ListItem>
                        </asp:DropDownList> </td>
                    <td><h3>Tarifa</h3><asp:TextBox CssClass="Textbox" ID="TbxTarifa" runat="server" placeholder="Tarifa"></asp:TextBox></td>
                </tr>
                <tr>
                    
                    <td><h3>Descripcion</h3><asp:TextBox CssClass="Textbox" ID="TbxDescripcion" runat="server" placeholder="Descripcion"></asp:TextBox></td>
                    <td><h3>Fecha Vigencia</h3><asp:TextBox CssClass="Textbox" ID="TbxFechaVigente" runat="server" placeholder="Fecha Vigente"></asp:TextBox></td>
                    <td><asp:Button ID="Btn_Actualizar" CssClass="Button" runat="server" Text="Actualizar"/></td>
                </tr>
                <tr>                     
                    <td colspan="2"><asp:ValidationSummary ID="ValidationTarifaBuses" runat="server" /></td>  
                    <td><asp:Button ID="Btn_Buscar" CssClass="auto-style4" runat="server" Text="BUSCAR CON ID TARIFA" Width="258px"/> </td>                             
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
                  <asp:BoundField HeaderText="FECHA VIGENCIA" DataField="FECHA VIGENCIA"  ItemStyle-Width="12%"/>                        
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
