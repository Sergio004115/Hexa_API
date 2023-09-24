using Hexa_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hexa_API.Persistence.Context
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }


        //SECCIÓN DONDE VAN LOS MODELOS PARA LA MIGRACIÓN DE LA BASE DE DATOS
        public DbSet<Jugadores> Jugadores { get; set; }
        public DbSet<Equipos> Equipos { get; set;}




    }
}
