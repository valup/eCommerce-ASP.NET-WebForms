using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class UsuarioConfiguration
    {
        public void Configure(EntityTypeConfiguration<Usuario> entity)
        {
            entity.ToTable("usuario");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Email);
            entity.Property(e => e.Password);
            entity.Property(e => e.Fecha);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<Usuario> entity);
    }
}