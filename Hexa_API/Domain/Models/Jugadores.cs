using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hexa_API.Domain.Models
{
    public class Jugadores
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [MaxLength(128)]
        public string IdJugador { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string Codigo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string Nombres { get; set; }
        [Required]
        public int Camiseta { get; set; }
        public string campeonatos { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(128)]
        public string IdEquipo { get; set; }
        public string CodigoEquipo { get; set; }
        public string NombreEquipo { get; set; }

        [ForeignKey("IdEquipo")]
        public Equipos Equipo { get; set; }


    }
}
