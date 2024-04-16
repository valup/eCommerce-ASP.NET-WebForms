using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AdoNet;

namespace eCommerceNet.Page
{
    public partial class Home : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var productos = _context.producto.ToList();
            dlProductos.DataSource = productos;
            dlProductos.DataBind();
        }
    }
}