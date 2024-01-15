
using System;
using System.Collections.Generic;

namespace eCommerceNet.Models
{
    public partial class OrdenPago
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public int IdMetodo { get; set; }

        public decimal Total { get; set; }

        public int IdDireccion { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Direccion IdDireccionNavigation { get; set; }

        public virtual MetodoPago IdMetodoNavigation { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }

        public virtual ICollection<OrdenDetalle> OrdenDetalles { get; set; } = new List<OrdenDetalle>();
    }
}