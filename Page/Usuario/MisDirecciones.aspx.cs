using AdoNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Usuario
{
    public partial class MisDirecciones : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("Ingresar.aspx");

            int userId = (int)Session["usuario"];
            var dirs = _context.direccion.Where(x => x.idUsuario == userId).ToList();
            dlDirecciones.DataSource = dirs;
            dlDirecciones.DataBind();
        }
    }
}