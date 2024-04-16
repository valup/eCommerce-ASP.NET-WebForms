using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.Models
{
    public class CarritoProducto
    {
        public AdoNet.carrito carrito { get; set; }
        public AdoNet.producto producto { get; set; }
        public int cantidadProducto { get; set; }
        public decimal total { get; set; }
    }
}