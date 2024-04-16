<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Usuario/MiCuenta.Master" AutoEventWireup="true" CodeBehind="MisOrdenes.aspx.cs" Inherits="eCommerceNet.Page.Usuario.MisOrdenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
	<link href="/Template/css/tiny-slider.css" rel="stylesheet">
	<link href="/Template/css/style.css" rel="stylesheet">

    <div class="container">
        <div class="row mb-5">
            <form class="col-md-12" method="post">
                <div class="site-blocks-table">
                    <table class="table">

                        <thead>
                            <tr>
                                <th> Mis Ordenes </th>
                            </tr>
                        </thead>

                        <tbody>
                            <asp:DataList ID="dlOrdenPagos" runat="server" OnItemDataBound="dlOrdenPagos_ItemDataBound">
                                <ItemTemplate>
                                    <asp:Label ID="lblOP" text='<%# Eval("id") %>' runat="server" Visible="false" />
                                    <thead>
                                        <th>
                                            Fecha: <%# Eval("fecha") %>
                                            <a href="\Page\Orden\DetallesOrden.aspx?id=<%# Eval("id")%>">Detalles</a>
                                        </th>
                                    </thead>
                                    <asp:DataList ID="dlDetalles" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td> <%# Eval("Item2.nombre") %> <strong class="mx-2">x</strong> <%# Eval("Item1.cantidad") %> </td>
                                                <td> <%# String.Format("{0,10:G}", (decimal)Eval("Item1.cantidad") * (int)Eval("Item2.precio")) %> </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:DataList>
                                    
                                </ItemTemplate>
                            </asp:DataList>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
    </div>

</asp:Content>
