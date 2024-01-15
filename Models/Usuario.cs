
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Fecha { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

        public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();

        public virtual ICollection<OrdenPago> OrdenPagos { get; set; } = new List<OrdenPago>();
    }
}