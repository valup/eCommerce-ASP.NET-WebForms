using AdoNet;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Productos
{
    public partial class DetallesProducto : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        private AdoNet.producto producto;
        private AdoNet.cantidadProducto cantidadDisponible;
        protected void Page_Load(object sender, EventArgs e)
        {
            var stringid = Request.QueryString["id"];

            if (stringid != null && stringid != "")
            {
                var id = Int32.Parse(stringid);
                producto = _context.producto.Find(id);

                linkImagen.NavigateUrl = producto.imagen;
                imagen.ImageUrl = producto.imagen;
                lblNombre.Text = producto.nombre;
                lblPrecio.Text = "$" + producto.precio.ToString();

                cantidadDisponible = _context.cantidadProducto.FirstOrDefault(x => x.idProducto == id);

                if (cantidadDisponible != null)
                {
                    if (cantidadDisponible.cantidad > 0)
                    {
                        lblStock.Text = "En Stock";
                        lblStock.CssClass = "text-success ms-2";
                    }
                    else
                    {
                        lblStock.Text = "Sin Stock";
                        lblStock.CssClass = "text-danger ms-2";
                    }

                }
            }
            
        }

        protected void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(tbCantidad.Text);

            if (cantidad < 0 || cantidadDisponible == null)
            {
                tbCantidad.Text = "0";
            }
            else if (cantidad > cantidadDisponible.cantidad)
            {
                tbCantidad.Text = cantidadDisponible.cantidad.ToString();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("../Usuario/Ingresar.aspx");

            var cantAgregar = Int32.Parse(tbCantidad.Text);

            if (cantAgregar > 0)
            {
                int userId = (int)Session["usuario"];
                var carrito = _context.carrito.FirstOrDefault(x => x.idUsuario == userId && x.idProducto == producto.id);

                if (carrito == null)
                {
                    carrito = new carrito();
                    carrito.idProducto = producto.id;
                    carrito.idUsuario = (int)Session["usuario"];
                    carrito.cantidad = 0;
                    _context.carrito.Add(carrito);
                }

                if (cantidadDisponible != null)
                {
                    if (carrito.cantidad + cantAgregar > cantidadDisponible.cantidad)
                        carrito.cantidad = cantidadDisponible.cantidad;
                    else
                        carrito.cantidad = cantAgregar;

                }

                _context.SaveChanges();

                lblAgregado.Text = "El producto fue agregado al carrito";
            }
        }
    }
}