<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            text-align: right;
            font-weight: bold;
            width: 168px;
        }
        .style4
        {
            text-align: left;
        }
        .style5
        {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td style="font-weight: 700; text-align: center; font-size: x-large; text-decoration: underline">
                    LISTADO DE PEDIDOS PARES QUE SE HAYAN VENDIDO EN LOS MESES IMPARES campeon</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" style="text-align: center">
                    Consulta 1: Listar todos los Productos por Pedidos Seleccionados</td>
            </tr>
            <tr>
                <td class="style5" style="text-align: center">
&nbsp; Consulta 2: Listar todos los datos de los Empleados Seleccionados</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" 
                        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
                        onitemcommand="DataList1_ItemCommand" RepeatColumns="3">
                        <AlternatingItemStyle BackColor="PaleGoldenrod" />
                        <FooterStyle BackColor="Tan" />
                        <HeaderStyle BackColor="Tan" Font-Bold="True" />
                        <HeaderTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="1" 
                                style="font-weight: 700">Consulta 1</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="2" 
                                style="font-weight: 700">Consulta 2</asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table border="7" class="style1">
                                <tr>
                                    <td class="style3">
                                        Nro. de Pedido :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                                            Text='<%# Eval("IdPedido") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Fecha de Pedido :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Fecha") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Codigo de Empleado :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label3" runat="server" style="font-weight: 700" 
                                            Text='<%# Eval("IdEmpleado") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Nombres de Empleado :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("NomEmpleado") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3" valign="top">
                                        Foto de Empleado :</td>
                                    <td class="style4">
                                        <asp:Image ID="Image1" runat="server" Height="82px" 
                                            ImageUrl='<%# Eval("IdEmpleado","imagenes/{0}.jpg") %>' Width="67px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Venta por Pedido :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Venta") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Nombre del Cliente :</td>
                                    <td class="style4">
                                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("NombreContacto") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        Seleccionar :</td>
                                    <td class="style4">
                                        <asp:CheckBox ID="CheckBox1" runat="server" style="font-weight: 700" />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
