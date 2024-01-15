
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class Direccion
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

        public virtual Usuario IdUsuarioNavigation { get; set; }

        public virtual ICollection<OrdenPago> OrdenPagos { get; set; } = new List<OrdenPago>();
    }
}