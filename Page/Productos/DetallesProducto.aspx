<%@ Page Title="" Language="C#" MasterPageFile="~/Page/eCommerce.Master" AutoEventWireup="true" CodeBehind="DetallesProducto.aspx.cs" Inherits="eCommerceNet.Page.Productos.DetallesProducto" %>
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
                <aside class="col-lg-6">
                    <div class="border rounded-4 mb-3 d-flex justify-content-center">
                        <asp:HyperLink ID="linkImagen" CssClass="rounded-4" runat="server">
                            <asp:Image ID="imagen" CssClass="rounded-4 fit" runat="server" Width="500px" />
                        </asp:HyperLink>
                    </div>
                </aside>
                <main class="col-lg-6">
                    <div class="ps-lg-3">
                        <h4 class="title text-dark">
                            <asp:Label ID="lblNombre" runat="server" />
                        </h4>
                        <div class="d-flex flex-row my-3">
                            <asp:Label ID="lblStock" runat="server" />
                        </div>

                        <div class="mb-3">
                            <asp:Label ID="lblPrecio" runat="server" CssClass="h5" />
                        </div>

                        <div class="row mb-4">
                            <div class="col-md-4 col-6 mb-3">
                                <label class="mb-2 d-block">Cantidad</label>
                                <div class="input-group mb-3" style="width: 170px;">
                                    <asp:TextBox ID="tbCantidad" Text="0" TextMode="Number" runat="server" Width="50px" AutoPostBack="True" OnTextChanged="tbCantidad_TextChanged" />
                                </div>
                            </div>
                        </div>

                        <asp:Button ID="btnAgregar" Text="Agregar al carrito" CssClass="btn btn-primary shadow-0" runat="server" OnClick="btnAgregar_Click" />
                        <asp:Label ID="lblAgregado" runat="server" CssClass="text-success" />
                    </div>
                </main>
            </div>
        </div>
    </section>

</asp:Content>
