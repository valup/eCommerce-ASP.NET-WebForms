using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class DireccionDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Opcional { get; set; }
    }
}