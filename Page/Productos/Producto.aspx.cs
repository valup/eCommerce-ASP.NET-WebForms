using eCommerceNet.Data;
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
        private eCommerceContext context = new eCommerceContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarDatos()
        {
            Models.Producto prod = new Models.Producto();

            prod.Nombre = tbNombre.Text;
            prod.Precio = Convert.ToDecimal(tbPrecio.Text);
            prod.Imagen = tbURL.Text;
            prod.Fecha = DateTime.Now;

            context.producto.Add(prod);
            context.SaveChanges();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}