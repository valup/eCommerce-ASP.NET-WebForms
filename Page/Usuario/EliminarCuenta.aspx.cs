using AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Usuario
{
    public partial class EliminarCuenta : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Ingresar.aspx");
            }
        }

        protected void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["usuario"];
            var user = _context.usuario.Find(userId);

            if (user != null)
            {
                var carritos = _context.carrito.Where(x => x.idUsuario == user.id);

                foreach (var c in carritos)
                {
                    _context.carrito.Remove(c);
                }


                var ordenPagos = _context.ordenPago.Where(x => x.idUsuario == user.id);

                foreach (var op in ordenPagos)
                {
                    var ordenDetalles = _context.ordenDetalle.Where(x => x.idOrdenPago == op.id);

                    foreach (var od in ordenDetalles)
                    {
                        _context.ordenDetalle.Remove(od);
                    }

                    _context.ordenPago.Remove(op);
                }


                var direcciones = _context.direccion.Where(x => x.idUsuario == user.id);

                foreach (var d in direcciones)
                {
                    _context.direccion.Remove(d);
                }

                _context.usuario.Remove(user);
                _context.SaveChanges();

                Session["usuario"] = null;
            }
        }
    }
}