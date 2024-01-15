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
                            + "<img  src='" + ctemp["producto"].Imagen + "' class=\"img-fluid product-thumbnail\">"
                            + "</td>"
                            + "<td class=\"product-name\">"
                            + "<h2 class=\"h5 text-black\">'" + ctemp["producto"].Nombre + "'</h2>"
                            + "</td>"
                            + "<td class=\"product-price\">"
                            + "<strong>'" + ctemp["producto"].Precio + "'</strong>"
                            + "</td>"
                            + "<td>"
                            + "<div class=\"input-group mb-3 d-flex align-items-center quantity-container\" style=\"max-width: 120px;\">"
                            + "<div class=\"input-group-prepend\">"
                            + "<asp:TextBox ID=\"" + ctemp["carrito"].Id + "\" TextMode=\"Number\" runat=\"server\" Text=\""
                            + ctemp["carrito"].Cantidad + "\" Width=\"50px\" OnTextChanged=\"tbCantidad_TextChanged\" AutoPostBack=\"True\" />"
                            + "</div>"
                            + "</td>"
                            + "<td>" + ctemp["total"] + "</td>"
                            + "<asp:Button ID=\"eliminarProducto\" CssClass=\"btn btn-outline-black\" Text=\"X\" runat=\"server\" OnClick=\"eliminarProducto_Click\" CommandArgument=\""
                            + ctemp["carrito"].Id + "\"/>"
                            + "</tr>"
                            );

                      }
                  %>
              </tbody>
            </table>
          </div>
        </form>
      </div>
      <div class="row">
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
                  <asp:Button ID="btnComprar" Text="Comprar" runat="server" CssClass="btn btn-black btn-lg py-3 btn-block" OnClick="btnComprar_Click" />
                </div>
              </div>
            </div>
          </div>
      </div>
    </div>

</asp:Content>
