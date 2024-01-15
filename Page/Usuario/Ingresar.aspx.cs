using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using eCommerceNet.Data;
using System.Security.Policy;

namespace eCommerceNet.Page.Usuario
{
    public partial class Ingresar : System.Web.UI.Page
    {
        private eCommerceContext _context = new eCommerceContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void autenticarUsuario()
        {
            Models.Usuario user = new Models.Usuario();
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;

            var users = from u in _context.usuario
                        where u.Email == tbEmail.Text && u.Password == tbPassword.Text
                        select u;

            if (users.Any())
            {
                Session["usuario"] = users.FirstOrDefault().Id;

                Response.Redirect("../Usuario/MiCuenta.aspx");
            }
            else
            {
                errorLogin.Text = "Email o password incorrectos.";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            autenticarUsuario();
        }
    }
}