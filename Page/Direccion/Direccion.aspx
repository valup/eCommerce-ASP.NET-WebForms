<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Direccion/DireccionMaster.Master" AutoEventWireup="true" CodeBehind="Direccion.aspx.cs" Inherits="eCommerceNet.Page.Direccion.Direccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Bootstrap CSS -->
    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
    <link href="/Template/css/tiny-slider.css" rel="stylesheet">
    <link href="/Template/css/style.css" rel="stylesheet">

    <div class="untree_co-section">
        <div class="container">
            <div class="row">
                <h2 class="h3 mb-3 text-black">Direccion </h2>
                <div class="col-md-6 mb-5 mb-md-0">

                    <div class="p-3 p-lg-5 border bg-white" >
                        <asp:Label ID="lblDirecciones" Text="Direccion de Envio" runat="server" />
                        <asp:DropDownList ID="cmbDirecciones" runat="server" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="cmbDirecciones_SelectedIndexChanged">
                            <asp:ListItem Text="Nueva Direccion" Value="" />
                        </asp:DropDownList>
                    </div>

                    <div class="p-3 p-lg-5 border bg-white">

                        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" />

                        <div class="form-group">
                            <asp:Label Text="Pais" runat="server" />
                            <asp:DropDownList ID="cmbPaises" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cmbPaises_SelectedIndexChanged" />
                            <br />
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="tbEstado" placeholder="Estado" MaxLength="50" />
                        </div>

                        <div class="form-group">
                            <asp:Label Text="Ciudad" runat="server" />
                            <asp:DropDownList ID="cmbCiudades" runat="server" AutoPostBack="true" />
                            <br />
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="tbCodigoPostal" placeholder="Codigo Postal" MaxLength="10" />
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="tbCalle" placeholder="Calle" MaxLength="50" />
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="tbNotas" placeholder="Notas (Opcional)" MaxLength="200" Multiline="true" />
                        </div>

                        <div class="form-group">
                            <asp:TextBox runat="server" ID="tbTelefono" placeholder="Telefono" MaxLength="20" />
                        </div>

                        <div class="form-group">
                            <asp:Label Text="Metodo de Pago" runat="server" />
                            <asp:DropDownList ID="cmbMetodoPago" runat="server" AutoPostBack="true" />
                            <br />
                        </div>

                    </div>
                </div>

                <div class="col-md-6">
                    <div class="row mb-5">
                        <div class="col-md-12">
                            <div class="p-3 p-lg-5 border bg-white">
                                <table class="table site-block-order-table mb-5">
                                    <thead>
                                        <th>Mi Orden</th>
                                    </thead>
                                    <tbody>
                                        <asp:DataList ID="dlCarritos" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td> <%# Eval("producto.nombre") %> <strong class="mx-2">x</strong> <%# Eval("carrito.cantidad") %> </td>
                                                    <td> |  Total: $<%# Eval("total") %> </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:DataList>

                                        <tr>
                                            <td class="text-black font-weight-bold"><strong>Total</strong></td>
                                            <td class="text-black font-weight-bold">
                                                <asp:Label ID="lblTotal" runat="server" />
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>

                                <div class="form-group">
                                    <asp:Button ID="btnConfirmar" Text="Confirmar Orden" runat="server" CssClass="btn btn-black btn-lg py-3 btn-block" OnClick="btnConfirmar_Click" />
                                </div>

                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
