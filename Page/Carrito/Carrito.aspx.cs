using eCommerceNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceNet.Page.Carrito
{
    public class CarritoTemp
    {
        public Models.Producto producto { get; set; }
        public int idUsuario { get; set; }
        public int cantidad { get; set; }
        public int cantidadDisponible { get; set; }
        public decimal total {  get; set; }

    }
    public partial class Carrito : System.Web.UI.Page
    {
        private eCommerceContext _context = new eCommerceContext();
        protected List<CarritoTemp> ctemps = new List<CarritoTemp>();
        protected void Page_Load(object sender, EventArgs e)
        {
            var carritos = _context.carrito.Where(x => x.Id == (Convert.ToInt32(Session["usuario"]) + 1)).ToList();
            foreach (var item in carritos)
            {
                var ctemp = new CarritoTemp();

                ctemp.cantidad = item.Cantidad;
                ctemp.idUsuario = item.IdUsuario;
                ctemp.producto = _context.producto.Find(item.IdProducto);
                ctemp.total = item.Cantidad * ctemp.producto.Precio;
                ctemp.cantidadDisponible = _context.cantidadProducto.FirstOrDefault(x => x.IdProducto == item.IdProducto).Cantidad;

                ctemps.Add(ctemp);
            }
        }

        protected decimal Total()
        {
            decimal total = 0;

            foreach (var ctemp in ctemps)
            {
                total += ctemp.total;
            }

            return total;
        }

        protected void eliminarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}