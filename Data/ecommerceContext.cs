using eCommerceNet.Data.Configuration;
using eCommerceNet.Models;
using System.Data.Entity;

namespace eCommerceNet.Data
{
    public partial class eCommerceContext : DbContext
    {
        public eCommerceContext() : base("eCommerceNet")
        {

        }

        public virtual DbSet<CantidadProducto> cantidadProducto { get; set; }
        public virtual DbSet<Carrito> carrito { get; set; }
        public virtual DbSet<Direccion> direccion { get; set; }
        public virtual DbSet<MetodoPago> metodoPago { get; set; }
        public virtual DbSet<OrdenDetalle> ordenDetalle { get; set; }
        public virtual DbSet<OrdenPago> ordenPago { get; set; }
        public virtual DbSet<Producto> producto { get; set; }
        public virtual DbSet<Usuario> usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<eCommerceContext>(null);

            CantidadProductoConfiguration cantidadProductoConfiguration = new CantidadProductoConfiguration();
            cantidadProductoConfiguration.Configure(modelBuilder.Entity<CantidadProducto>());

            CarritoConfiguration carritoConfiguration = new CarritoConfiguration();
            carritoConfiguration.Configure(modelBuilder.Entity<Carrito>());

            DireccionConfiguration direccionConfiguration = new DireccionConfiguration();
            direccionConfiguration.Configure(modelBuilder.Entity<Direccion>());

            MetodoPagoConfiguration metodoPagoConfiguration = new MetodoPagoConfiguration();
            metodoPagoConfiguration.Configure(modelBuilder.Entity<MetodoPago>());

            OrdenDetalleConfiguration ordenDetalleConfiguration = new OrdenDetalleConfiguration();
            ordenDetalleConfiguration.Configure(modelBuilder.Entity<OrdenDetalle>());

            OrdenPagoConfiguration ordenPagoConfiguration = new OrdenPagoConfiguration();
            ordenPagoConfiguration.Configure(modelBuilder.Entity<OrdenPago>());

            ProductoConfiguration productoConfiguration = new ProductoConfiguration();
            productoConfiguration.Configure(modelBuilder.Entity<Producto>());

            UsuarioConfiguration usuarioConfiguration = new UsuarioConfiguration();
            usuarioConfiguration.Configure(modelBuilder.Entity<Usuario>());

            base.OnModelCreating(modelBuilder);
        }
    }
}