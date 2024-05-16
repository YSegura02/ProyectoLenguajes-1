using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Proyecto_Hotel.Models
{
    public class DbContextCliente : DbContext
    {
        public DbContextCliente(DbContextOptions<DbContextCliente> options) : base(options)
        {

        }//fin del metodo constructor

        // Creacion Db set
        public DbSet<Cliente> clientes { get; set; }
        //

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente()
            {
                Cedula = 207840954,
                TipoCedula = "209280528",
                NombreCompleto = "",
                Telefono = 83760911,
                Direccion = "",
                email = "yulianas@gmail.com",
                Rol = 1

            });//fin de insertar datos 

        }//fin del metodo

    }
}
