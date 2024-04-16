using AdoNet;
using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Direccion
{
    public partial class Direccion : System.Web.UI.Page
    {
        private eCommerceNetEntities _context = new eCommerceNetEntities();
        List<CarritoProducto> cps;
        AdoNet.direccion direccion = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("/Page/Usuario/Ingresar.aspx");

                List<AdoNet.direccion> direcciones = _context.direccion.ToList();
                cmbDirecciones.DataSource = direcciones;
                cmbDirecciones.DataBind();
                cmbDirecciones.DataValueField = "id";
                cmbDirecciones.DataTextField = "calle";
                cmbDirecciones.DataBind();

                List<AdoNet.Pais> paises = _context.Pais.ToList();
                cmbPaises.DataSource = paises;
                cmbPaises.DataBind();
                cmbPaises.DataValueField = "PaisCodigo";
                cmbPaises.DataTextField = "PaisNombre";
                cmbPaises.DataBind();

                List<AdoNet.metodoPago> metodos = _context.metodoPago.ToList();
                cmbMetodoPago.DataSource = metodos;
                cmbMetodoPago.DataBind();
                cmbMetodoPago.DataValueField = "id";
                cmbMetodoPago.DataTextField = "nombre";
                cmbMetodoPago.DataBind();

                int userId = (int)Session["usuario"];
                var carritos = _context.carrito.Where(x => x.idUsuario == userId);
                decimal total = 0;

                cps = new List<CarritoProducto>();
                foreach (var carrito in carritos)
                {
                    var producto = _context.producto.Find(carrito.idProducto);

                    var cp = new CarritoProducto();
                    cp.carrito = carrito;
                    cp.producto = producto;
                    cp.total = carrito.cantidad * producto.precio;

                    cps.Add(cp);

                    total += cp.total;
                }

                dlCarritos.DataSource = cps;
                dlCarritos.DataBind();

                lblTotal.Text = total.ToString();

            }
            else
            {
                cps = (List<CarritoProducto>)Session["carrito"];
            }
        }

        protected void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaises.SelectedIndex != -1 && cmbPaises.SelectedValue != "")
            {
                var dropdown = (DropDownList)sender;

                cmbCiudades.DataSource = _context.Ciudad.Where(x => x.PaisCodigo == dropdown.SelectedValue).ToList();
                cmbCiudades.DataBind();
                cmbCiudades.DataValueField = "CiudadId";
                cmbCiudades.DataTextField = "CiudadNombre";
                cmbCiudades.DataBind();
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbDirecciones.SelectedIndex != -1 && cmbPaises.SelectedIndex != -1 && cmbMetodoPago.SelectedIndex != -1 && cmbCiudades.SelectedIndex != -1
                && tbCalle.Text != "" && tbCodigoPostal.Text != "" && tbEstado.Text != "" && tbTelefono.Text != "")
            {
                if (cmbDirecciones.SelectedValue != "")
                {
                    int idDir = Int32.Parse(cmbDirecciones.SelectedValue);
                    direccion = _context.direccion.Find(idDir);
                    direccion.idUsuario = (int)Session["usuario"];
                    direccion.pais = cmbPaises.SelectedValue;
                    direccion.ciudad = cmbCiudades.SelectedValue;
                    direccion.calle = tbCalle.Text;
                    direccion.codigoPostal = tbCodigoPostal.Text;
                    direccion.estado = tbEstado.Text;
                    direccion.opcional = tbNotas.Text;
                    direccion.telefono = tbTelefono.Text;
                    _context.SaveChanges();
                }
                else
                {
                    direccion = new AdoNet.direccion();
                    direccion.idUsuario = (int)Session["usuario"];
                    direccion.pais = cmbPaises.SelectedValue;
                    direccion.ciudad = cmbCiudades.SelectedValue;
                    direccion.calle = tbCalle.Text;
                    direccion.codigoPostal = tbCodigoPostal.Text;
                    direccion.estado = tbEstado.Text;
                    direccion.opcional = tbNotas.Text;
                    direccion.telefono = tbTelefono.Text;

                    _context.direccion.Add(direccion);
                    _context.SaveChanges();
                }

                if (direccion != null)
                {

                    var ordenPago = new AdoNet.ordenPago();
                    ordenPago.idDireccion = direccion.id;
                    ordenPago.idUsuario = (int)Session["usuario"];
                    ordenPago.idMetodo = Int32.Parse(cmbMetodoPago.SelectedValue);
                    ordenPago.total = Decimal.Parse(lblTotal.Text);
                    ordenPago.fecha = DateTime.Now;

                    _context.ordenPago.Add(ordenPago);
                    _context.SaveChanges(); // para obtener el nuevo ID

                    foreach (var cp in cps)
                    {
                        var ordenDetalle = new AdoNet.ordenDetalle();
                        ordenDetalle.idOrdenPago = ordenPago.id;
                        ordenDetalle.idProducto = cp.producto.id;
                        ordenDetalle.cantidad = cp.carrito.cantidad;
                        ordenDetalle.precioProducto = cp.producto.precio;

                        _context.ordenDetalle.Add(ordenDetalle);

                        AdoNet.cantidadProducto cantProd = _context.cantidadProducto.FirstOrDefault(x => x.idProducto == cp.producto.id);

                        cantProd.cantidad -= cp.carrito.cantidad;

                        AdoNet.carrito c = _context.carrito.Find(cp.carrito.id);
                        _context.carrito.Remove(c);
                        _context.SaveChanges();
                    }

                    Response.Redirect("Gracias.aspx");
                }
                else
                {
                    lblError.Text = "Por favor complete todos los campos requeridos";
                }
            }
            else
            {
                lblError.Text = "Por favor complete todos los campos requeridos";
            }
        }

        protected void cmbDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbDirecciones.SelectedValue != "")
            {
                int idDir = Int32.Parse(cmbDirecciones.SelectedValue);
                var direccion = _context.direccion.Find(idDir);

                cmbPaises.SelectedValue = direccion.pais;

                cmbCiudades.DataSource = _context.Ciudad.Where(x => x.PaisCodigo == direccion.pais).ToList();
                cmbCiudades.DataBind();
                cmbCiudades.DataValueField = "CiudadId";
                cmbCiudades.DataTextField = "CiudadNombre";
                cmbCiudades.DataBind();

                cmbCiudades.SelectedValue = direccion.ciudad;
                tbCalle.Text = direccion.calle;
                tbCodigoPostal.Text = direccion.codigoPostal;
                tbEstado.Text = direccion.estado;
                tbNotas.Text = direccion.opcional;
                tbTelefono.Text = direccion.telefono;
            }
            else
            {
                cmbPaises.SelectedValue = "ARG";

                cmbCiudades.DataSource = _context.Ciudad.Where(x => x.PaisCodigo == "ARG").ToList();
                cmbCiudades.DataBind();
                cmbCiudades.DataValueField = "CiudadId";
                cmbCiudades.DataTextField = "CiudadNombre";
                cmbCiudades.DataBind();

                cmbCiudades.SelectedValue = "69";
                tbCalle.Text = "";
                tbCodigoPostal.Text = "";
                tbEstado.Text = "";
                tbNotas.Text = "";
                tbTelefono.Text = "";
            }

        }
    }
}