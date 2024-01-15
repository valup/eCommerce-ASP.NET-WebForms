
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class Carrito
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}