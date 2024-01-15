using eCommerceNet.Data;
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
        private eCommerceContext _context = new eCommerceContext();
        protected List<Dictionary<string, dynamic>> ctemps = new List<Dictionary<string, dynamic>>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("../../Usuario/Ingresar.aspx");
            }
            else
            {
                var carritos = _context.carrito.Where(x => x.Id == (int) Session["usuario"]).ToList();
                foreach (var item in carritos)
                {
                    var ctemp = new Dictionary<string, dynamic>();

                    ctemp["carrito"] = item;
                    ctemp["producto"] = _context.producto.Find(item.IdProducto);
                    ctemp["total"] = item.Cantidad * ctemp["producto"].Precio;
                    ctemp["cantidadProducto"] = _context.cantidadProducto.FirstOrDefault(x => x.IdProducto == item.IdProducto);

                    ctemps.Add(ctemp);
                }
            }
        }

        protected decimal Total()
        {
            decimal total = 0;

            foreach (var ctemp in ctemps)
            {
                total += ctemp["total"];
            }

            return total;
        }

        protected void eliminarProducto_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            int id = Int32.Parse(boton.CommandArgument);

            var ctemp = ctemps.FirstOrDefault(x => x["carrito"].Id == id);

            Models.Carrito carrito = _context.carrito.Remove(ctemp["carrito"]);
            _context.SaveChanges();

            ctemps.Remove(ctemp);
        }

        protected void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            int id = Int32.Parse(tb.ID);
            int cantidad = Int32.Parse(tb.Text);

            var ctemp = ctemps.FirstOrDefault(x => x["carrito"].Id == id);

            if (cantidad < 0)
            {
                tb.Text = "0";
                cantidad = 0;
            }
            else if (cantidad > ctemp["cantidadProducto"])
            {
                tb.Text = ctemp["cantidadProducto"].ToString();
                cantidad = ctemp["cantidadProducto"];
            }

            Models.Carrito carrito = _context.carrito.Find(id);

            if (carrito != null)
            {
                carrito.Cantidad = cantidad;
                _context.SaveChanges();
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Session["carritos"] = ctemps;
            Response.Redirect("../../Direccion/Direccion.aspx");
        }
    }
}