using AdoNet;

using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Usuario
{
    public partial class MisOrdenes : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("Ingresar.aspx");

            int userId = (int)Session["usuario"];
            List<AdoNet.ordenPago> ops = _context.ordenPago.Where(x => x.idUsuario == userId).ToList();

            dlOrdenPagos.DataSource = ops;
            dlOrdenPagos.DataBind();
        }

        protected void dlOrdenPagos_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            foreach (DataListItem item in dlOrdenPagos.Items)
            {
                Label lblOP = (Label)item.FindControl("lblOP");
                int idOP = Int32.Parse(lblOP.Text);
                var ods = _context.ordenDetalle.Where(x => x.idOrdenPago == idOP).ToList();
                List<OrdenProducto> odps = new List<OrdenProducto>();

                foreach (var od in ods)
                {
                    var prod = _context.producto.Find(od.idProducto);

                    var odp = new OrdenProducto();

                    odps.Add(odp);
                }

                DataList detalles = e.Item.FindControl("dlDetalles") as DataList;
                detalles.DataSource = odps;
                detalles.DataBind();

            }
        }
    }
}