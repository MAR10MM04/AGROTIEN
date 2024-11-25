
using AGROTIEND.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using  AGROTIEND.Controllers;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace AGROTIEND.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {

        // Define tus DbSets aquí
        public required DbSet<Producto> Productos { get; set; }
        public required DbSet<Usuarios> Usuarios { get; set; }

        public required DbSet<Ventas> Ventas { get; set;}
        public required DbSet<Detalle_Carrito> Detalle_Carritos { get; set;}

        public required DbSet<Calificacion> Calificacion { get; set;}

        public required DbSet<Carrito> Carrito { get; set;}

        public required DbSet<Detalle_Ventas> Detalle_Ventas { get; set;}

        public required DbSet<Pasarela_Pago> Pasarela_Pagos { get; set;}

        public required DbSet<Chat> Chat { get; set;}


    }

}
