using AdoNet;
using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Orden
{
    public partial class DetallesOrden : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        AdoNet.ordenPago op;
        List<OrdenProducto> odps;
        protected void Page_Load(object sender, EventArgs e)
        {
            var stringid = Request.QueryString["id"];

            if (stringid != null && stringid != "")
            {
                var id = Int32.Parse(stringid);
                op = _context.ordenPago.Find(id);

                lblFecha.Text = op.fecha.ToShortDateString();

                var metodoPago = _context.metodoPago.Find(op.idMetodo);
                if (metodoPago != null)
                    lblMetodoPago.Text = metodoPago.nombre;

                var direccion = _context.direccion.Find(op.idDireccion);
                if (direccion != null)
                {
                    lblPais.Text = direccion.pais;
                    lblEstado.Text = direccion.estado;
                    lblCiudad.Text = direccion.ciudad;
                    lblCP.Text = direccion.codigoPostal;
                    lblCalle.Text = direccion.calle;
                    lblTel.Text = direccion.telefono;
                    lblNotas.Text = direccion.opcional;
                }

                odps = new List<OrdenProducto>();
                var ods = _context.ordenDetalle.Where(x => x.idOrdenPago == op.id).ToList();

                decimal total = 0;
                foreach (var od in ods)
                {
                    var producto = _context.producto.Find(od.idProducto);

                    var odp = new OrdenProducto();
                    odp.ordenDetalle = od;
                    odp.producto = producto;
                    odp.total = od.cantidad * producto.precio;

                    odps.Add(odp);
                    total += odp.total;
                }
                lblTotal.Text = total.ToString();

                dlProductos.DataSource = odps;
                dlProductos.DataBind();
            }

        }
    }
}