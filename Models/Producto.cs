
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Precio { get; set; }

        public string Imagen { get; set; }

        public virtual ICollection<CantidadProducto> CantidadProductos { get; set; } = new List<CantidadProducto>();

        public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

        public virtual ICollection<OrdenDetalle> OrdenDetalles { get; set; } = new List<OrdenDetalle>();
    }
}