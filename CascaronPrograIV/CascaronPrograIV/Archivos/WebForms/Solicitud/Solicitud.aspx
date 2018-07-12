<%@ Page Title="" Language="C#" MasterPageFile="~/Archivos/WebForms/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Solicitud.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Solicitud.Solicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../HojasdeEstilos/Solicitud/EstiloSolicitud.css" rel="stylesheet" type="text/css" />
    <div>
        <div id="DivCrear">
            <h1>Crear Solicitud de Viaticos</h1>
            <br />
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
                <asp:Button ID="Btn_Guardar" CssClass="Button" runat="server" Text="Guardar" />
        </div>
        <br />
        <br />
        <div id="DivConsultar">
            <h1>Consultar Solicitudes de Viaticos</h1>
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
    </div>
</asp:Content>
