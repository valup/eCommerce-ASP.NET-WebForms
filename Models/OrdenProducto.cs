using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.Models
{
    public class OrdenProducto
    {
        public AdoNet.ordenDetalle ordenDetalle { get; set; }
        public AdoNet.producto producto { get; set; }
        public decimal total { get; set; }
    }
}