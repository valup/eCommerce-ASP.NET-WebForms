<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Carrito/CarritoMaster.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="eCommerceNet.Page.Carrito.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
      <div class="row mb-5">
        <form class="col-md-12" method="post">
          <div class="site-blocks-table">
            <table class="table">

              <thead>
                <tr>
                  <th class="product-thumbnail">Imagen</th>
                  <th class="product-name">Nombre</th>
                  <th class="product-price">Precio</th>
                  <th class="product-quantity">Cantidad</th>
                  <th class="product-total">Total</th>
                  <th class="product-remove">Eliminar</th>
                </tr>
              </thead>

              <tbody>
                  <%

                      foreach(var ctemp in ctemps)
                      {
                          Response.Write("<li>"
                            + "<tr>"
                            + "<td class=\"product-thumbnail\">\r\n"
                            + "<img  src='" + ctemp.producto.Imagen + "' class=\"img-fluid product-thumbnail\">"
                            + "</td>"
                            + "<td class=\"product-name\">"
                            + "<h2 class=\"h5 text-black\">'" + ctemp.producto.Nombre + "'</h2>"
                            + "</td>"
                            + "<td class=\"product-price\">"
                            + "<strong>'" + ctemp.producto.Precio + "'</strong>"
                            + "</td>"
                            + "<td>"
                            + "<div class=\"input-group mb-3 d-flex align-items-center quantity-container\" style=\"max-width: 120px;\">"
                            + "<div class=\"input-group-prepend\">"
                            + "<asp:TextBox ID=\"tbCantidad\" TextMode=\"Number\" runat=\"server\" Text=\""
                            + ctemp.cantidad + "\" Width=\"50px\" min=\"0\" max=\""
                            + ctemp.cantidadDisponible + "\"></asp:TextBox>"
                            + "<asp:RangeValidator runat=\"server\" ControlToValidate=\"tbCantidad\" ErrorMessage=\"La cantidad esta fuera del rango disponible\""
                            + " Type=\"Integer\" MinimumValue=\"0\" MaximumValue=\"" + ctemp.cantidadDisponible + "\" ForeColor=\"Red\"></asp:RangeValidator>"
                            + "</div>"
                            + "</td>"
                            + "<td>" + ctemp.total + "</td>"
                            + "<asp:Button ID=\"eliminarProducto\" CssClass=\"btn btn-outline-black\" Text=\"X\" runat=\"server\" OnClick=\"eliminarProducto_Click\" />"
                            + "</tr>"
                            );

                      }
                  %>
              </tbody>
            </table>
          </div>
        </form>
      </div>
        
        <asp:RangeValidator runat="server" ControlToValidate="tbCantidad" ErrorMessage="La cantidad esta fuera del rango disponible"
            Type="Integer" MinimumValue="0" MaximumValue="10" ForeColor="Red"></asp:RangeValidator>
      <div class="row">
        <div class="col-md-6">
          <div class="row mb-5">
            <div class="col-md-6 mb-3 mb-md-0">
              <button class="btn btn-black btn-sm btn-block">Actualizar Carrito</button>
            </div>
            <div class="col-md-6">
              <button class="btn btn-outline-black btn-sm btn-block">Seguir Comprando</button>
            </div>
          </div>
        </div>
        <div class="col-md-6 pl-5">
          <div class="row justify-content-end">
            <div class="col-md-7">
              <div class="row mb-5">
                <div class="col-md-6">
                  <span class="text-black">Total</span>
                </div>
                <div class="col-md-6 text-right">
                  <strong class="text-black"> <% Response.Write(Total()); %></strong>
                </div>
              </div>
        
              <div class="row">
                <div class="col-md-12">
                  <a class="btn btn-black btn-lg py-3 btn-block" href="..\Productos\Productos.aspx">Comprar</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

</asp:Content>
