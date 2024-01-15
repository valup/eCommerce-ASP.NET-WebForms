
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class CantidadProducto
    {
        public int Id { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}