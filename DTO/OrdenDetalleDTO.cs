using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class OrdenDetalleDTO
    {
        public int Id { get; set; }
        public int IdOrdenPago { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
    }
}