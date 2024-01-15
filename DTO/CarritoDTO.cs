using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class CarritoDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}