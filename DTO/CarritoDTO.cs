using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public static class CarritoDTO
    {
        public static AdoNet.carrito carrito { get; set; }
        public static AdoNet.producto producto { get; set; }
        public static int cantidadProducto { get; set; }
        public static decimal total { get; set; }
    }
}