<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Orden/Orden.Master" AutoEventWireup="true" CodeBehind="DetallesOrden.aspx.cs" Inherits="eCommerceNet.Page.Orden.DetallesOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
	<link href="/Template/css/tiny-slider.css" rel="stylesheet">
	<link href="/Template/css/style.css" rel="stylesheet">

    <section class="py-5">
        <div class="container">
            <div class="row gx-5">
                <main class="col-lg-12">
                    <div class="ps-lg-3">
                        <div class="form-control">
                            Fecha: <asp:Label ID="lblFecha" runat="server" />
                        </div>
                        <div class="form-control">
                            Metodo de Pago: <asp:Label ID="lblMetodoPago" runat="server" />
                        </div>
                        <div class="form-control">
                            <table class="table">
                                <thead>
                                    <th>Direccion de envio:</th>
                                </thead>
                                <tr>
                                    <td> | Pais: <asp:Label ID="lblPais" runat="server" /> </td>
                                    <td> | Estado: <asp:Label ID="lblEstado" runat="server" /> </td>
                                    <td> | Ciudad: <asp:Label ID="lblCiudad" runat="server" /> </td>
                                    <td> | Codigo Postal: <asp:Label ID="lblCP" runat="server" /> </td>
                                    <td> | Calle: <asp:Label ID="lblCalle" runat="server" /> </td>
                                    <td> | Telefono: <asp:Label ID="lblTel" runat="server" /> </td>
                                    <td> | Notas: <asp:Label ID="lblNotas" runat="server" /> </td>
                                </tr>
                            </table>
                        </div>
                        <div class="form-control">
                            <table class="table">

                                <tbody>
                                    <asp:DataList ID="dlProductos" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="product-thumbnail">
                                                    <asp:Image ImageUrl='<%# Eval("producto.imagen")%>' runat="server" Width="100px" />
                                                </td>
                                                <td class="product-name">
                                                    <h2 class="h5 text-black"> <%# Eval("producto.nombre") %> </h2>
                                                </td>
                                                <td class="product-price">
                                                    Precio Unitario: $
                                                    <asp:Label ID="lblPrecio" Text='<%# Eval("producto.precio") %>' runat="server" />
                                                </td>
                                                <td>
                                                    Cantidad:
                                                    <asp:Label ID="lblCantidad" Text='<%# Eval("ordenDetalle.cantidad") %>' runat="server" />
                                                </td>
                                                <td>
                                                    Total:
                                                    <asp:Label ID="lblTotalProd" Text='<%# Eval("total") %>' runat="server" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:DataList>
                                </tbody>
                            </table>
                        </div>

                        <div class="form-control">
                            Total: <asp:Label ID="lblTotal" runat="server"/>
                        </div>
                    </div>
                </main>
            </div>
        </div>
    </section>
</asp:Content>
