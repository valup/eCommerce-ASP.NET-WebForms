
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class MetodoPago
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<OrdenPago> OrdenPagos { get; set; } = new List<OrdenPago>();
    }
}