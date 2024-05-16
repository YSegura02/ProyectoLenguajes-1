using Microsoft.EntityFrameworkCore;

namespace Proyecto_Hotel.Models
{
	public class DbContextPaquete : DbContext
	{
		public DbContextPaquete(DbContextOptions<DbContextPaquete> options) : base(options)
		{

		}//fin del metodo constructor

		//Creacion de DbSet
		public DbSet<Paquete> citas { get; set; }


		//creacion de protected, para hacer insercion de datos
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Paquete>().HasData(new Paquete()
			{
				tipoPaquete = "",
				prima = 0,
				CantidadMensualidades= 0,
				montoTotal = 0,
			});

		}//fin de insertar datos 

	}//fin class
}//fin 
