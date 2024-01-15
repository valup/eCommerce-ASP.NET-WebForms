using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceNet.Data.Configuration
{
    public partial class MetodoPagoConfiguration
    {
        public void Configure(EntityTypeConfiguration<MetodoPago> entity)
        {
            entity.ToTable("metodoPago");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nombre);

            OnConfigurationPartial(entity);
        }

        partial void OnConfigurationPartial(EntityTypeConfiguration<MetodoPago> entity);
    }
}