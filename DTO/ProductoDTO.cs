using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }
}