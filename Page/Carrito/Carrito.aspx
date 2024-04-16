<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Carrito/CarritoMaster.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="eCommerceNet.Page.Carrito.Carrito" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row mb-5">
            <form class="col-md-12" method="post">
                <div class="site-blocks-table">
                    <table class="table">

                        <tbody>
                            <asp:DataList ID="dlCarrito" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td class="product-thumbnail">
                                            <asp:Image ImageUrl='<%# Eval("producto.imagen")%>' runat="server" Width="100px" />
                                        </td>
                                        <td class="product-name">
                                            <asp:Label ID="lblNombre" CssClass="h5 text-black" Text='<%# Eval("producto.nombre") %>' runat="server" />
                                        </td>
                                        <td class="product-price">
                                            Precio: $
                                            <asp:Label ID="lblPrecio" Text='<%# Eval("producto.precio") %>' runat="server" />
                                        </td>
                                        <td>
                                            <div class="input-group mb-3 d-flex align-items-center quantity-container" style="max-width: 120px;">
                                                <div class="input-group-prepend">
                                                    <asp:TextBox ID="tbCantidad" Text='<%# Eval("carrito.cantidad") %>' TextMode="Number" runat="server" Width="100px" />
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            Total: $
                                            <asp:Label ID="lblTotalProd" Text='<%# Eval("total") %>' runat="server" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnActualizar" Text="Actualizar" runat="server" CommandArgument='<%# Eval("carrito.id") %>' OnClick="ActualizarCarrito" AutoPostback="true" />
                                        </td>
                                        <td>
                                            <asp:Button ID="eliminarProducto" CssClass="btn btn-outline-black" Text="Eliminar" runat="server" OnClick="eliminarProducto_Click" CommandArgument='<%# Eval("carrito.id") %>' />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:DataList>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
        <div class="row">
            <div class="row justify-content-end">
                <div class="col-md-7">
                    <div class="row mb-5">
                        <div class="col-md-12">
                            Total: $
                            <asp:Label ID="lblTotal" runat="server" />
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                            <asp:Button ID="btnComprar" Text="Comprar" runat="server" CssClass="btn btn-black btn-lg py-3 btn-block" OnClick="btnComprar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
