using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class OrdenDetalleConfiguration
    {
        public void Configure(EntityTypeConfiguration<OrdenDetalle> entity)
        {
            entity.ToTable("ordenDetalle");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IdProducto);
            entity.Property(e => e.PrecioProducto);
            entity.Property(e => e.IdOrdenPago);
            entity.Property(e => e.Cantidad);
            entity.HasIndex(e => e.IdProductoNavigation);
            entity.HasIndex(e => e.IdOrdenPagoNavigation);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<OrdenDetalle> entity);
    }
}