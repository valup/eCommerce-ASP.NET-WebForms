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

using System.Security.Policy;
using AdoNet;

namespace eCommerceNet.Page.Usuario
{
    public partial class Ingresar : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
                Response.Redirect("CerrarSesion.aspx");
        }

        private void autenticarUsuario()
        {
            AdoNet.usuario user = new AdoNet.usuario();
            user.email = tbEmail.Text;
            user.password = tbPassword.Text;

            var users = from u in _context.usuario
                        where u.email == tbEmail.Text && u.password == tbPassword.Text
                        select u;

            if (users.Any())
            {
                Session["usuario"] = users.FirstOrDefault().id;

                Response.Redirect("../Usuario/MiCuenta.aspx");
            }
            else
            {
                errorLogin.Text = "Email o password incorrectos.";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
                errorLogin.Text = "Por favor ingrese email y password";
            else
                autenticarUsuario();
        }
    }
}