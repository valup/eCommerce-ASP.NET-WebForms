
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class OrdenDetalle
    {
        public int Id { get; set; }

        public int IdOrdenPago { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioProducto { get; set; }

        public virtual OrdenPago IdOrdenPagoNavigation { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}