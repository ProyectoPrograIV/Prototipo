<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CascaronPrograIV.Archivos.WebForms.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../HojasdeEstilos/EstiloMenu.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
    <form runat="server">
    <div class="div">
        <br />
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="Menu" BorderColor="Black" BorderStyle="Solid" BorderWidth="4px" ForeColor="White" RenderingMode="Table">
            <Items>
                <asp:MenuItem Text="Parametrizaciones" Value="Parametrizaciones"></asp:MenuItem>
                <asp:MenuItem Text="Solicitud de Viaticos" Value="Solicitud de Viaticos"></asp:MenuItem>
                <asp:MenuItem Text="Orden de Viaticos" Value="Orden de Viaticos"></asp:MenuItem>
                <asp:MenuItem Text="Liquidacion de Viaticos" Value="Liquidacion de Viaticos"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
    </form>
</body>
</html>
