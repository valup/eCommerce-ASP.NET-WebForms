using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class OrdenPagoConfiguration
    {
        public void Configure(EntityTypeConfiguration<OrdenPago> entity)
        {
            entity.ToTable("ordenPago");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IdUsuario);
            entity.Property(e => e.IdMetodo);
            entity.Property(e => e.IdDireccion);
            entity.Property(e => e.Fecha);
            entity.Property(e => e.Total);
            entity.HasIndex(e => e.IdUsuarioNavigation);
            entity.HasIndex(e => e.IdMetodoNavigation);
            entity.HasIndex(e => e.IdDireccionNavigation);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<OrdenPago> entity);
    }
}