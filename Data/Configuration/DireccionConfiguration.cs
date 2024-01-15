using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class DireccionConfiguration
    {
        public void Configure(EntityTypeConfiguration<Direccion> entity)
        {
            entity.ToTable("direccion");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.IdUsuario);
            entity.Property(e => e.Pais);
            entity.Property(e => e.Estado);
            entity.Property(e => e.Calle);
            entity.Property(e => e.Telefono);
            entity.Property(e => e.Ciudad);
            entity.Property(e => e.CodigoPostal);
            entity.Property(e => e.Opcional);
            entity.HasIndex(e => e.IdUsuarioNavigation);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<Direccion> entity);
    }
}