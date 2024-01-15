using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eCommerceNet.Data;

namespace eCommerceNet.Page
{
    public partial class Home : System.Web.UI.Page
    {
        private eCommerceContext _context = new eCommerceContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected List<Models.Producto> ListaProductos()
        {
            return _context.producto.ToList();
        }

        //protected void Detalle(object sender, EventArgs e)
        //{
        //    int id = Convert.ToInt32((sender as ImageButton).CommandArgument);
        //    Response.Redirect("Productos/Detalle.aspx?Id=" + id);
        //}
    }
}