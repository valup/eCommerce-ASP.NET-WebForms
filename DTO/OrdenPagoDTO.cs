using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class OrdenPagoDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdMetodo { get; set; }
        public decimal Total { get; set; }
        public int IdDireccion { get; set; }
        public DateTime Fecha { get; set; }
    }
}