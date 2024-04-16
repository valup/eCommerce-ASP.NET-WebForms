using AdoNet;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Productos
{
    public partial class Producto : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void cargarDatos()
        {
            AdoNet.producto prod = new AdoNet.producto();

            prod.nombre = tbNombre.Text;
            var test = tbPrecio.Text;
            prod.precio = Decimal.Parse(tbPrecio.Text);
            prod.imagen = tbURL.Text;
            prod.fecha = DateTime.Now;

            _context.producto.Add(prod);
            _context.SaveChanges();

            AdoNet.cantidadProducto cantidad = new AdoNet.cantidadProducto();
            cantidad.idProducto = prod.id;
            cantidad.cantidad = Int32.Parse(tbCantidad.Text);

            _context.cantidadProducto.Add(cantidad);
            _context.SaveChanges();

            lblResultado.Text = "Producto agregado correctamente!";
            lblResultado.CssClass = "text-success";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}