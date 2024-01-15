using eCommerceNet.Data;
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
        private eCommerceContext _context = new eCommerceContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool existeEmail()
        {
            //var users = from u in _context.usuario
            //            where u.Email == tbEmail.Text
            //            select u;

            //var users = _context.usuario.Where(u => u.Email == tbEmail.Text).ToList();
            
            var users = _context.usuario.FirstOrDefault(u => u.Email == tbEmail.Text);

            if (users != null)
            {
                errorExiste.Text = "El email ya esta en uso.";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void agregarUsuario()
        {
            Models.Usuario user = new Models.Usuario();
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;
            user.Fecha = DateTime.Now;

            _context.usuario.Add(user);
            _context.SaveChanges();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!existeEmail())
            {
                agregarUsuario();
                Response.Redirect("Ingresar.aspx");
            }
            else
            {
                errorExiste.Text = "El email ya esta en uso.";
            }
        }
    }
}