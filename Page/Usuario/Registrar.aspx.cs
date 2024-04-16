using AdoNet;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Usuario
{
    public partial class Registrar : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool existeEmail()
        {
            var users = from u in _context.usuario
                        where u.email == tbEmail.Text
                        select u;

           return users.Any();
        }

        private void agregarUsuario()
        {
            AdoNet.usuario user = new AdoNet.usuario();
            user.email = tbEmail.Text;
            user.password = tbPassword.Text;
            user.fecha = DateTime.Now;

            _context.usuario.Add(user);
            _context.SaveChanges();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "" )
            {
                error.Text = "Por favor ingrese email y password";
            }
            else if (existeEmail())
            {
                error.Text = "El email ya esta en uso.";
            }
            else
            {
                agregarUsuario();
                Response.Redirect("Ingresar.aspx");
            }
        }
    }
}