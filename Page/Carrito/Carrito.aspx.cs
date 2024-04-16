using AdoNet;
using eCommerceNet.DTO;
using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Carrito
{
    public partial class Carrito : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        private List<CarritoProducto> cps;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("/Page/Usuario/Ingresar.aspx");

                cps = new List<CarritoProducto>();
                int userId = (int)Session["usuario"];
                var carritos = _context.carrito.Where(x => x.idUsuario == userId);
                decimal total = 0;

                foreach (var carrito in carritos)
                {
                    var cantProd = _context.cantidadProducto.FirstOrDefault(x => x.idProducto == carrito.idProducto);

                    if (cantProd != null) // verifico que las cantidades sean correctas
                    {
                        if (carrito.cantidad < 0)
                        {
                            carrito.cantidad = 0;
                        }
                        else if (carrito.cantidad > cantProd.cantidad)
                        {
                            carrito.cantidad = cantProd.cantidad;
                        }

                    }

                    var producto = _context.producto.Find(carrito.idProducto);

                    var cp = new CarritoProducto();
                    cp.carrito = carrito;
                    cp.producto = producto;
                    cp.cantidadProducto = cantProd.cantidad;
                    cp.total = carrito.cantidad * producto.precio;

                    cps.Add(cp);

                    total += cp.total;
                }

                MapeoCarritoDTO(cps);

                dlCarrito.DataSource = cps;
                dlCarrito.DataBind();

                lblTotal.Text = total.ToString();

                Session["carrito"] = cps;
            }
            else
            {
                cps = Session["carrito"] as List<CarritoProducto>;
            }
        }

        protected void eliminarProducto_Click(object sender, EventArgs e)
        {
            var item = dlCarrito;
            Button button = (Button)sender;
            DataListItem panel = (DataListItem)button.Parent;

            int idCarrito = Int32.Parse(button.CommandArgument);

            var cp = cps.Find(x => x.carrito.id == idCarrito);
            cps.Remove(cp);

            var c = _context.carrito.Find(cp.carrito.id);
            if (c != null)
            {
                _context.carrito.Remove(c);
                _context.SaveChanges();
            }

            decimal total = 0;
            foreach (var carrito in cps)
            {
                total += carrito.total;
            }
            lblTotal.Text = total.ToString();

            dlCarrito.DataSource = cps;
            dlCarrito.DataBind();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Page/Direccion/Direccion.aspx");
        }

        private void MapeoCarritoDTO(List<CarritoProducto> cps)
        {
            foreach (var item in cps)
            {
                ListaCarritoDTO.ListaCarrito.Add(item);
            }
        }

        protected void ActualizarCarrito(object sender, EventArgs e)
        {
            var item = dlCarrito;
            Button button = (Button)sender;
            DataListItem panel = (DataListItem)button.Parent;
            TextBox tbCantidad = (TextBox)panel.FindControl("tbCantidad");

            int idCarrito = Int32.Parse(button.CommandArgument);

            var cp = cps.Find(x => x.carrito.id == idCarrito);

            cp.carrito.cantidad = Int32.Parse(tbCantidad.Text);
            if (cp.carrito.cantidad > cp.cantidadProducto)
                cp.carrito.cantidad = cp.cantidadProducto;
            else if (cp.carrito.cantidad < 1)
                cp.carrito.cantidad = 1;

            cp.total = cp.carrito.cantidad * cp.producto.precio;

            var c = _context.carrito.Find(cp.carrito.id);
            c.cantidad = cp.carrito.cantidad;
            _context.SaveChanges();

            decimal total = 0;
            foreach (var carrito in cps)
            {
                total += carrito.total;
            }
            lblTotal.Text = total.ToString();

            dlCarrito.DataSource = cps;
            dlCarrito.DataBind();
        }
    }
}